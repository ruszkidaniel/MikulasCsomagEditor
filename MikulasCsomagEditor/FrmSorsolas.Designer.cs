namespace MikulasCsomagEditor
{
    partial class FrmSorsolas
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
            this.osztalyCB = new System.Windows.Forms.ComboBox();
            this.randomBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.a_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aID = new System.Windows.Forms.TextBox();
            this.kID = new System.Windows.Forms.TextBox();
            this.swapBTN = new System.Windows.Forms.Button();
            this.doneBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Válaszd ki az osztályt:";
            // 
            // osztalyCB
            // 
            this.osztalyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.osztalyCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osztalyCB.Location = new System.Drawing.Point(16, 54);
            this.osztalyCB.Name = "osztalyCB";
            this.osztalyCB.Size = new System.Drawing.Size(168, 33);
            this.osztalyCB.TabIndex = 1;
            this.osztalyCB.SelectedIndexChanged += new System.EventHandler(this.osztalyCB_SelectedIndexChanged);
            // 
            // randomBTN
            // 
            this.randomBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.randomBTN.Location = new System.Drawing.Point(238, 50);
            this.randomBTN.Name = "randomBTN";
            this.randomBTN.Size = new System.Drawing.Size(261, 43);
            this.randomBTN.TabIndex = 2;
            this.randomBTN.Text = "Véletlenszerű összepárosítás";
            this.randomBTN.UseVisualStyleBackColor = true;
            this.randomBTN.Click += new System.EventHandler(this.randomBTN_Click);
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
            this.a_ID,
            this.ad,
            this.k_ID,
            this.kap});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(16, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(483, 224);
            this.dataGridView1.TabIndex = 3;
            // 
            // a_ID
            // 
            this.a_ID.HeaderText = "a_ID";
            this.a_ID.Name = "a_ID";
            this.a_ID.ReadOnly = true;
            // 
            // ad
            // 
            this.ad.HeaderText = "ad";
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            // 
            // k_ID
            // 
            this.k_ID.HeaderText = "k_ID";
            this.k_ID.Name = "k_ID";
            this.k_ID.ReadOnly = true;
            // 
            // kap
            // 
            this.kap.HeaderText = "kap";
            this.kap.Name = "kap";
            this.kap.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "a_ID1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(164, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "a_ID2";
            // 
            // aID
            // 
            this.aID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aID.Location = new System.Drawing.Point(13, 388);
            this.aID.Name = "aID";
            this.aID.Size = new System.Drawing.Size(61, 32);
            this.aID.TabIndex = 5;
            // 
            // kID
            // 
            this.kID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kID.Location = new System.Drawing.Point(167, 386);
            this.kID.Name = "kID";
            this.kID.Size = new System.Drawing.Size(61, 32);
            this.kID.TabIndex = 5;
            // 
            // swapBTN
            // 
            this.swapBTN.Enabled = false;
            this.swapBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.swapBTN.Location = new System.Drawing.Point(81, 388);
            this.swapBTN.Name = "swapBTN";
            this.swapBTN.Size = new System.Drawing.Size(80, 32);
            this.swapBTN.TabIndex = 6;
            this.swapBTN.Text = "csere";
            this.swapBTN.UseVisualStyleBackColor = true;
            // 
            // doneBTN
            // 
            this.doneBTN.Enabled = false;
            this.doneBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.doneBTN.Location = new System.Drawing.Point(301, 387);
            this.doneBTN.Name = "doneBTN";
            this.doneBTN.Size = new System.Drawing.Size(198, 32);
            this.doneBTN.TabIndex = 6;
            this.doneBTN.Text = "Véglegesítés!";
            this.doneBTN.UseVisualStyleBackColor = true;
            this.doneBTN.Click += new System.EventHandler(this.doneBTN_Click);
            // 
            // FrmSorsolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(524, 430);
            this.Controls.Add(this.doneBTN);
            this.Controls.Add(this.swapBTN);
            this.Controls.Add(this.kID);
            this.Controls.Add(this.aID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.randomBTN);
            this.Controls.Add(this.osztalyCB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSorsolas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSorsolas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSorsolas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox osztalyCB;
        private System.Windows.Forms.Button randomBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn k_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn kap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aID;
        private System.Windows.Forms.TextBox kID;
        private System.Windows.Forms.Button swapBTN;
        private System.Windows.Forms.Button doneBTN;
    }
}