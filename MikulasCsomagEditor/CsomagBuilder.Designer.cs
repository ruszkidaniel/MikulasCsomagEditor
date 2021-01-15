namespace MikulasCsomagEditor
{
    partial class CsomagBuilder
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
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addBTN = new System.Windows.Forms.Button();
            this.statsBTN = new System.Windows.Forms.Button();
            this.buyBTN = new System.Windows.Forms.Button();
            this.valueLBL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.termek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadingLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "értékhatár";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(207, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ft";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(114, 26);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(303, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "írd be az azonosítód";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(469, 23);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(47, 20);
            this.idTB.TabIndex = 2;
            this.idTB.TextChanged += new System.EventHandler(this.idTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "termék";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(146, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "X";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // amountTB
            // 
            this.amountTB.Location = new System.Drawing.Point(168, 121);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(47, 20);
            this.amountTB.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(221, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "db";
            // 
            // addBTN
            // 
            this.addBTN.Enabled = false;
            this.addBTN.Location = new System.Drawing.Point(30, 163);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(218, 23);
            this.addBTN.TabIndex = 4;
            this.addBTN.Text = "csomagba tesz!";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // statsBTN
            // 
            this.statsBTN.Enabled = false;
            this.statsBTN.Location = new System.Drawing.Point(30, 298);
            this.statsBTN.Name = "statsBTN";
            this.statsBTN.Size = new System.Drawing.Size(218, 23);
            this.statsBTN.TabIndex = 4;
            this.statsBTN.Text = "statisztika";
            this.statsBTN.UseVisualStyleBackColor = true;
            // 
            // buyBTN
            // 
            this.buyBTN.Enabled = false;
            this.buyBTN.Location = new System.Drawing.Point(307, 298);
            this.buyBTN.Name = "buyBTN";
            this.buyBTN.Size = new System.Drawing.Size(218, 23);
            this.buyBTN.TabIndex = 4;
            this.buyBTN.Text = "Csomag megvásárlása!";
            this.buyBTN.UseVisualStyleBackColor = true;
            // 
            // valueLBL
            // 
            this.valueLBL.AutoSize = true;
            this.valueLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valueLBL.ForeColor = System.Drawing.Color.White;
            this.valueLBL.Location = new System.Drawing.Point(303, 256);
            this.valueLBL.Name = "valueLBL";
            this.valueLBL.Size = new System.Drawing.Size(204, 20);
            this.valueLBL.TabIndex = 0;
            this.valueLBL.Text = "csomag értéke jelenleg: - Ft";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(303, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "csomag tartalma jelenleg:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.termek,
            this.db});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(307, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(218, 132);
            this.dataGridView1.TabIndex = 5;
            // 
            // termek
            // 
            this.termek.HeaderText = "termek";
            this.termek.Name = "termek";
            this.termek.ReadOnly = true;
            // 
            // db
            // 
            this.db.HeaderText = "db";
            this.db.Name = "db";
            this.db.ReadOnly = true;
            // 
            // loadingLBL
            // 
            this.loadingLBL.AutoSize = true;
            this.loadingLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadingLBL.ForeColor = System.Drawing.Color.Black;
            this.loadingLBL.Location = new System.Drawing.Point(50, 143);
            this.loadingLBL.Name = "loadingLBL";
            this.loadingLBL.Size = new System.Drawing.Size(70, 17);
            this.loadingLBL.TabIndex = 0;
            this.loadingLBL.Text = "betöltés...";
            // 
            // CsomagBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(548, 353);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buyBTN);
            this.Controls.Add(this.statsBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.valueLBL);
            this.Controls.Add(this.loadingLBL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CsomagBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CsomagBuilder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CsomagBuilder_FormClosing);
            this.Load += new System.EventHandler(this.CsomagBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button statsBTN;
        private System.Windows.Forms.Button buyBTN;
        private System.Windows.Forms.Label valueLBL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn termek;
        private System.Windows.Forms.DataGridViewTextBoxColumn db;
        private System.Windows.Forms.Label loadingLBL;
    }
}