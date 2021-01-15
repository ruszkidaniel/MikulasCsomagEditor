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
    public partial class FrmMain : Form
    {
        static string connectionString;

        public FrmMain()
        {
            InitializeComponent();
            connectionString = @"Server=(localdb)\MSSQLLocalDB;AttachDbFileName=|DataDirectory|\Resources\mikulas.mdf;Trusted_Connection=True;";
        }

        /* Ablak mozgatása */
        // https://stackoverflow.com/a/1592899

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /* Bezárás gomb */

        private void closeBTN_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Biztosan ki szeretnél lépni?", "Bezárás", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
                this.Close();
        }

        private void frmOsztalyBTN_Click(object sender, EventArgs e)
        {
            FrmOsztaly frmOsztaly = new FrmOsztaly(connectionString);
            frmOsztaly.ShowDialog();
        }

        private void sorsolasBTN_Click(object sender, EventArgs e)
        {
            FrmSorsolas frmSorsolas = new FrmSorsolas(connectionString);
            frmSorsolas.ShowDialog();
        }

        private void csomagepitoBTN_Click(object sender, EventArgs e)
        {
            CsomagBuilder csomagBuilder = new CsomagBuilder(connectionString);
            csomagBuilder.ShowDialog();
        }
    }
}
