using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikulasCsomagEditor
{
    public partial class FrmOsztaly : Form
    {
        static SqlConnection conn;

        public FrmOsztaly(string connectionString)
        {
            InitializeComponent();
            ConnectDatabase(connectionString);
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

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            txtFilePath.Text = ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : null;
        }

        private void FrmOsztaly_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            osztalyjelzesTB.Enabled = addToDBBTN.Enabled = File.Exists(txtFilePath.Text);
        }

        private void addToDBBTN_Click(object sender, EventArgs e)
        {
            /* Check errors */

            if (osztalyjelzesTB.Text.Trim().Length == 0) {
                MessageBox.Show("Nincs megadva osztályjelzés!");
                return;
            }

            /* Fetch names from txt */

            List<string> diakok = new List<string>();
            StreamReader sr = new StreamReader(txtFilePath.Text, Encoding.UTF8);
            while (!sr.EndOfStream) diakok.Add(sr.ReadLine());
            sr.Close();

            /* Execute query */

            SqlTransaction tr = conn.BeginTransaction();
            try
            {
                SqlCommand sql = conn.CreateCommand();
                sql.Transaction = tr;
                sql.CommandType = CommandType.Text;
                sql.CommandText = "INSERT INTO emberek (nev, osztaly) VALUES (@nev, @osztaly)";
                sql.Parameters.Add("@nev", SqlDbType.VarChar);
                sql.Parameters.AddWithValue("@osztaly", osztalyjelzesTB.Text);
                foreach (string diak in diakok)
                {
                    sql.Parameters[0].Value = diak;
                    sql.ExecuteNonQuery();
                }
                tr.Commit();
                MessageBox.Show("Osztály betöltve.");
                this.Close();
            }
            catch(Exception ex)
            {
                tr.Rollback();
                MessageBox.Show("Nem sikerült betölteni az osztályt.");
            }
            
        }
    }
}
