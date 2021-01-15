using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikulasCsomagEditor
{
    public partial class FrmSorsolas : Form
    {
        static SqlConnection conn;
        Random rnd = new Random();
        Dictionary<int, string> students;

        public FrmSorsolas(string connectionString)
        {
            InitializeComponent();
            ConnectDatabase(connectionString);
            GetClasses();
        }

        private void GetClasses()
        {
            osztalyCB.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT osztaly FROM emberek", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                osztalyCB.Items.Add(reader["osztaly"]);
            }
            reader.Close();
        }

        private void ConnectDatabase(string connectionString)
        {
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz.");
                Console.WriteLine(e);
                this.Close();
            }
        }

        private void FrmSorsolas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void osztalyCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = osztalyCB.SelectedIndex;
            if (id == -1) return;

            /* Fetch students from the selected class */

            students = new Dictionary<int, string>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM emberek WHERE osztaly = @osztaly", conn);
            cmd.Parameters.AddWithValue("@osztaly", osztalyCB.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int studentID = int.Parse(reader["id"].ToString());
                students.Add(studentID, (string)reader["nev"]);
            }
            reader.Close();

            /* Fill datagridview */

            FillDataGridView(false);

        }

        private void FillDataGridView(bool randomPairing)
        {
            if (students == null) return;
            dataGridView1.Rows.Clear();

            /* Get column 1 and 2 from id 1 -> n */

            List<int> a_ids = students.Keys.ToList();
            List<int> k_ids = students.Keys.ToList();

            if (randomPairing)
            {
                /* If the user clicked at random pairing, assign it randomly */

                a_ids = a_ids.OrderBy((item) => rnd.Next()).ToList();
                k_ids = k_ids.OrderBy((item) => rnd.Next()).ToList();

                for (int i = 0; i < a_ids.Count; i++)
                {
                    /* swap if the two ids are the same */

                    if(a_ids[i] == k_ids[i])
                    {
                        int value = k_ids[i];
                        int next = i == k_ids.Count - 1 ? 0 : i + 1;
                        k_ids[i] = k_ids[next];
                        k_ids[next] = value;
                    }
                }

            } else 
            {
                /* Normally we just load the pairs from the database */

                Tuple<List<int>, List<int>> ids = GetPairingIDs();
                if(ids != null)
                {
                    /* but only if they paired already */
                    a_ids = ids.Item1;
                    k_ids = ids.Item2;
                }
            }

            // fill the DGV

            Console.WriteLine(string.Join(",",a_ids));
            Console.WriteLine(string.Join(",",students.Keys));
            for (int i = 0; i < a_ids.Count; i++)
            {
                dataGridView1.Rows.Add(a_ids[i], students[a_ids[i]], k_ids[i], students[k_ids[i]]);
            }

            /* Enable buttons only if dgv is filled */

            swapBTN.Enabled = doneBTN.Enabled = a_ids.Count > 0;
        }

        private Tuple<List<int>, List<int>> GetPairingIDs()
        {
            List<int> a_ids = new List<int>();
            List<int> k_ids = new List<int>();

            //SqlCommand cmd = new SqlCommand("SELECT csomagok.kitol, e_kitol.nev as kitol_nev, csomagok.kinek, e_kinek.nev as kinek_nev FROM csomagok, emberek as e_kitol, emberek as e_kinek WHERE e_kitol.osztaly = e_kinek.osztaly AND e_kitol.osztaly = @osztaly AND csomagok.ev = @ev AND csomagok.kitol = e_kitol.id AND csomagok.kinek = e_kinek.id", conn);
            //but since we only want ids:
            SqlCommand cmd = new SqlCommand("SELECT kitol, kinek FROM csomagok, emberek WHERE csomagok.ev = @ev AND emberek.osztaly = @osztaly AND emberek.id = csomagok.kitol", conn);

            cmd.Parameters.AddWithValue("@ev", DateTime.Now.Year);
            cmd.Parameters.AddWithValue("@osztaly", osztalyCB.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                a_ids.Add(int.Parse(reader["kitol"].ToString()));
                k_ids.Add(int.Parse(reader["kinek"].ToString()));
            }
            reader.Close();

            if (a_ids.Count == 0) return null;
            return new Tuple<List<int>, List<int>>(a_ids, k_ids);
        }

        private void randomBTN_Click(object sender, EventArgs e)
        {
            FillDataGridView(true);
        }

        private void doneBTN_Click(object sender, EventArgs e)
        {
            SqlTransaction tr = conn.BeginTransaction();
            try
            {
                SqlCommand sql = conn.CreateCommand();
                sql.Transaction = tr;
                sql.CommandType = CommandType.Text;
                sql.CommandText = "INSERT INTO csomagok (kitol, kinek, ev) VALUES (@kitol, @kinek, @ev)";
                sql.Parameters.AddWithValue("@ev", DateTime.Now.Year);
                sql.Parameters.Add("@kitol", SqlDbType.Int);
                sql.Parameters.Add("@kinek", SqlDbType.Int);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sql.Parameters[1].Value = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    sql.Parameters[2].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    sql.ExecuteNonQuery();
                }
                tr.Commit();
                MessageBox.Show("Párok elmentve.");
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                tr.Rollback();
                MessageBox.Show("Nem sikerült elmenteni a párokat.");
            }

        }
    }
}
