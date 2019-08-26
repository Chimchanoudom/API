namespace Library
{
    partial class expense_detail
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
            this.btnfind = new System.Windows.Forms.Button();
            this.chname = new System.Windows.Forms.CheckBox();
            this.chid = new System.Windows.Forms.CheckBox();
            this.pnname = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnid = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnfind.Font = new System.Drawing.Font("Khmer OS", 12F);
            this.btnfind.ForeColor = System.Drawing.Color.White;
            this.btnfind.Location = new System.Drawing.Point(592, 43);
            this.btnfind.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(111, 44);
            this.btnfind.TabIndex = 0;
            this.btnfind.Text = "ស្វែងរក";
            this.btnfind.UseVisualStyleBackColor = false;
            // 
            // chname
            // 
            this.chname.AutoSize = true;
            this.chname.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.chname.Location = new System.Drawing.Point(8, 87);
            this.chname.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chname.Name = "chname";
            this.chname.Size = new System.Drawing.Size(127, 32);
            this.chname.TabIndex = 1;
            this.chname.Text = "ប្រភេទចំណាយ";
            this.chname.UseVisualStyleBackColor = true;
            // 
            // chid
            // 
            this.chid.AutoSize = true;
            this.chid.Checked = true;
            this.chid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chid.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.chid.Location = new System.Drawing.Point(8, 41);
            this.chid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chid.Name = "chid";
            this.chid.Size = new System.Drawing.Size(85, 32);
            this.chid.TabIndex = 1;
            this.chid.Text = "អត្ថលេខ";
            this.chid.UseVisualStyleBackColor = true;
            // 
            // pnname
            // 
            this.pnname.Controls.Add(this.comboBox1);
            this.pnname.Enabled = false;
            this.pnname.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.pnname.Location = new System.Drawing.Point(194, 97);
            this.pnname.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnname.Name = "pnname";
            this.pnname.Size = new System.Drawing.Size(360, 38);
            this.pnname.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 30);
            this.comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(838, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "លេខរៀង";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ការពិពណ៌នា";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "តម្លៃចំណាយ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ប្រភេទចំណាយ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Khmer OS", 11F);
            this.panel2.Location = new System.Drawing.Point(0, 215);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 282);
            this.panel2.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Font = new System.Drawing.Font("Khmer OS", 12F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(713, 43);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 44);
            this.button5.TabIndex = 0;
            this.button5.Text = "ស្វែងរក";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // txtid
            // 
            this.txtid.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtid.Location = new System.Drawing.Point(0, 0);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(340, 29);
            this.txtid.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(143, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "លុបព័ត៌មាន ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(9, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 44);
            this.button2.TabIndex = 0;
            this.button2.Text = "កែព័ត៌មាន";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 65);
            this.panel1.TabIndex = 18;
            // 
            // pnid
            // 
            this.pnid.Controls.Add(this.txtid);
            this.pnid.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.pnid.Location = new System.Drawing.Point(194, 49);
            this.pnid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnid.Name = "pnid";
            this.pnid.Size = new System.Drawing.Size(360, 36);
            this.pnid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btnfind);
            this.groupBox1.Controls.Add(this.chname);
            this.groupBox1.Controls.Add(this.chid);
            this.groupBox1.Controls.Add(this.pnname);
            this.groupBox1.Controls.Add(this.pnid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Khmer OS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.groupBox1.Size = new System.Drawing.Size(838, 150);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ស្វែងរក";
            // 
            // expense_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "expense_detail";
            this.Text = "expense_detail";
            this.pnname.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnid.ResumeLayout(false);
            this.pnid.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.CheckBox chname;
        private System.Windows.Forms.CheckBox chid;
        private System.Windows.Forms.Panel pnname;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnid;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}