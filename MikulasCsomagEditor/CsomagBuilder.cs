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
    public partial class CsomagBuilder : Form
    {
        SqlConnection conn;
        Dictionary<string, Tuple<int, int>> items;
        int packageId = -1, packageValue = 0;

        public CsomagBuilder(string connectionString)
        {
            InitializeComponent();
            ConnectDatabase(connectionString);
        }

        private void LoadItems()
        {
            items = new Dictionary<string, Tuple<int, int>>();
            SqlCommand cmd = new SqlCommand("SELECT nev, egysegar, id FROM belevalok", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                /* store item */
                items.Add(
                    reader["nev"].ToString(), 
                    new Tuple<int, int>(
                        int.Parse(reader["egysegar"].ToString()), 
                        int.Parse(reader["id"].ToString())
                    )
                );
                
                /* add to cb */
                comboBox1.Items.Add(reader["nev"].ToString());
                loadingLBL.Visible = false;
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

        private void CsomagBuilder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void CsomagBuilder_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void idTB_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            /* Get the current package ID from the given user ID */

            int userId;
            if (!int.TryParse(idTB.Text, out userId))
            {
                addBTN.Enabled = statsBTN.Enabled = buyBTN.Enabled = false;
                return;
            }

            SqlCommand cmd = new SqlCommand("SELECT csomagok.id FROM csomagok INNER JOIN emberek ON emberek.id = csomagok.kitol WHERE csomagok.kitol = @userId", conn);
            cmd.Parameters.AddWithValue("@userId", userId);
            SqlDataReader reader = cmd.ExecuteReader();

            bool success = reader.Read();
            addBTN.Enabled = statsBTN.Enabled = buyBTN.Enabled = success;
            if(success)
            {
                packageId = int.Parse(reader["id"].ToString());
            } else
            {
                packageId = -1;
                MessageBox.Show("Ezzel az azonosítóval nincs párosítva senki sem.");
                reader.Close();
                return;
            }
            
            reader.Close();

            /* Get the contents of package */

            UpdatePackageContents();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            string belevalo = comboBox1.SelectedItem.ToString();
            if (comboBox1.SelectedIndex == -1 || packageId == -1 || !items.Keys.Contains(belevalo)) return;

            int amount;
            if (!int.TryParse(amountTB.Text, out amount) || amount < 1)
            {
                MessageBox.Show("Érvényes mennyiséget adj meg!");
                return;
            }

            int newValue = packageValue + items[belevalo].Item1 * amount;
            if (newValue > numericUpDown1.Value)
            {
                MessageBox.Show("Ez már nem férne bele az értékhatárba! ("+newValue+")");
                return;
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO osszetetel(csomag, belevalo, mennyiseg) VALUES (@csomag, @belevalo, @mennyiseg)",conn);
            cmd.Parameters.AddWithValue("@csomag", packageId);
            cmd.Parameters.AddWithValue("@belevalo", items[belevalo].Item2);
            cmd.Parameters.AddWithValue("@mennyiseg", amount);
            cmd.ExecuteNonQuery();

            UpdatePackageContents();
        }

        private void UpdatePackageContents()
        {
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT belevalok.nev, osszetetel.mennyiseg FROM belevalok LEFT JOIN osszetetel ON belevalok.id = osszetetel.belevalo WHERE osszetetel.csomag = @packageId", conn);
            cmd.Parameters.AddWithValue("@packageId", packageId);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["nev"].ToString(), reader["mennyiseg"].ToString());
            }
            reader.Close();

            UpdatePackageValue();
        }

        private void UpdatePackageValue()
        {
            int value = 0;

            foreach (DataGridViewRow r in dataGridView1.Rows)
                value += items[r.Cells[0].Value.ToString()].Item1 * int.Parse(r.Cells[1].Value.ToString());

            packageValue = value;

            valueLBL.Text = "csomag értéke jelenleg: " + value + " Ft";
        }
    }
}
