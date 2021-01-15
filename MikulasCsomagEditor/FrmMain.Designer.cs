namespace MikulasCsomagEditor
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.frmOsztalyBTN = new System.Windows.Forms.Button();
            this.sorsolasBTN = new System.Windows.Forms.Button();
            this.csomagepitoBTN = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MikulasCsomagEditor.Properties.Resources.csomag_BG;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmOsztalyBTN
            // 
            this.frmOsztalyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.frmOsztalyBTN.Location = new System.Drawing.Point(160, 4);
            this.frmOsztalyBTN.Name = "frmOsztalyBTN";
            this.frmOsztalyBTN.Size = new System.Drawing.Size(317, 67);
            this.frmOsztalyBTN.TabIndex = 1;
            this.frmOsztalyBTN.Text = "osztály betöltése";
            this.frmOsztalyBTN.UseVisualStyleBackColor = true;
            this.frmOsztalyBTN.Click += new System.EventHandler(this.frmOsztalyBTN_Click);
            // 
            // sorsolasBTN
            // 
            this.sorsolasBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sorsolasBTN.Location = new System.Drawing.Point(160, 77);
            this.sorsolasBTN.Name = "sorsolasBTN";
            this.sorsolasBTN.Size = new System.Drawing.Size(317, 67);
            this.sorsolasBTN.TabIndex = 1;
            this.sorsolasBTN.Text = "sorsolás";
            this.sorsolasBTN.UseVisualStyleBackColor = true;
            this.sorsolasBTN.Click += new System.EventHandler(this.sorsolasBTN_Click);
            // 
            // csomagepitoBTN
            // 
            this.csomagepitoBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.csomagepitoBTN.Location = new System.Drawing.Point(160, 150);
            this.csomagepitoBTN.Name = "csomagepitoBTN";
            this.csomagepitoBTN.Size = new System.Drawing.Size(317, 67);
            this.csomagepitoBTN.TabIndex = 1;
            this.csomagepitoBTN.Text = "csomagépítő";
            this.csomagepitoBTN.UseVisualStyleBackColor = true;
            this.csomagepitoBTN.Click += new System.EventHandler(this.csomagepitoBTN_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeBTN.ForeColor = System.Drawing.Color.Green;
            this.closeBTN.Location = new System.Drawing.Point(160, 223);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(317, 67);
            this.closeBTN.TabIndex = 1;
            this.closeBTN.Text = "Kilépés";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(485, 297);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.csomagepitoBTN);
            this.Controls.Add(this.sorsolasBTN);
            this.Controls.Add(this.frmOsztalyBTN);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button frmOsztalyBTN;
        private System.Windows.Forms.Button sorsolasBTN;
        private System.Windows.Forms.Button csomagepitoBTN;
        private System.Windows.Forms.Button closeBTN;
    }
}

