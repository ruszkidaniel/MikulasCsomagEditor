namespace MikulasCsomagEditor
{
    partial class FrmOsztaly
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.osztalyjelzesTB = new System.Windows.Forms.TextBox();
            this.addToDBBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osztálynévsor tallózása:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(17, 80);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(406, 20);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSelectFile.Location = new System.Drawing.Point(450, 71);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(158, 34);
            this.BtnSelectFile.TabIndex = 2;
            this.BtnSelectFile.Text = "Tallózás";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Írja be az osztályjelzést:";
            // 
            // osztalyjelzesTB
            // 
            this.osztalyjelzesTB.Enabled = false;
            this.osztalyjelzesTB.Location = new System.Drawing.Point(311, 143);
            this.osztalyjelzesTB.Name = "osztalyjelzesTB";
            this.osztalyjelzesTB.Size = new System.Drawing.Size(297, 20);
            this.osztalyjelzesTB.TabIndex = 1;
            // 
            // addToDBBTN
            // 
            this.addToDBBTN.Enabled = false;
            this.addToDBBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addToDBBTN.Location = new System.Drawing.Point(18, 183);
            this.addToDBBTN.Name = "addToDBBTN";
            this.addToDBBTN.Size = new System.Drawing.Size(590, 34);
            this.addToDBBTN.TabIndex = 2;
            this.addToDBBTN.Text = "Hozzáadás adatbázishoz";
            this.addToDBBTN.UseVisualStyleBackColor = true;
            this.addToDBBTN.Click += new System.EventHandler(this.addToDBBTN_Click);
            // 
            // FrmOsztaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(634, 240);
            this.Controls.Add(this.addToDBBTN);
            this.Controls.Add(this.BtnSelectFile);
            this.Controls.Add(this.osztalyjelzesTB);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmOsztaly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmOsztaly";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOsztaly_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox osztalyjelzesTB;
        private System.Windows.Forms.Button addToDBBTN;
    }
}