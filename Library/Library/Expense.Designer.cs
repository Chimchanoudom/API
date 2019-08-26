namespace Library
{
    partial class Expense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button5 = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.chdob = new System.Windows.Forms.CheckBox();
            this.chname = new System.Windows.Forms.CheckBox();
            this.chid = new System.Windows.Forms.CheckBox();
            this.pnname = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnemail = new System.Windows.Forms.Panel();
            this.cmemail = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btndetail = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.pnid = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.chemail = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnname.SuspendLayout();
            this.pnemail.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnid.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Font = new System.Drawing.Font("Khmer OS", 12F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(719, 69);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 43);
            this.button5.TabIndex = 0;
            this.button5.Text = "ស្វែងរក";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnfind.Font = new System.Drawing.Font("Khmer OS", 12F);
            this.btnfind.ForeColor = System.Drawing.Color.White;
            this.btnfind.Location = new System.Drawing.Point(584, 69);
            this.btnfind.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(113, 43);
            this.btnfind.TabIndex = 0;
            this.btnfind.Text = "ស្វែងរក";
            this.btnfind.UseVisualStyleBackColor = false;
            // 
            // chdob
            // 
            this.chdob.AutoSize = true;
            this.chdob.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.chdob.Location = new System.Drawing.Point(9, 114);
            this.chdob.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chdob.Name = "chdob";
            this.chdob.Size = new System.Drawing.Size(100, 32);
            this.chdob.TabIndex = 1;
            this.chdob.Text = "ថ្ងៃចំណាយ";
            this.chdob.UseVisualStyleBackColor = true;
            // 
            // chname
            // 
            this.chname.AutoSize = true;
            this.chname.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.chname.Location = new System.Drawing.Point(9, 69);
            this.chname.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chname.Name = "chname";
            this.chname.Size = new System.Drawing.Size(90, 32);
            this.chname.TabIndex = 1;
            this.chname.Text = "ថ្ងៃកត់ត្រា";
            this.chname.UseVisualStyleBackColor = true;
            // 
            // chid
            // 
            this.chid.AutoSize = true;
            this.chid.Checked = true;
            this.chid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chid.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.chid.Location = new System.Drawing.Point(9, 30);
            this.chid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chid.Name = "chid";
            this.chid.Size = new System.Drawing.Size(85, 32);
            this.chid.TabIndex = 1;
            this.chid.Text = "អត្ថលេខ";
            this.chid.UseVisualStyleBackColor = true;
            // 
            // pnname
            // 
            this.pnname.Controls.Add(this.dateTimePicker1);
            this.pnname.Enabled = false;
            this.pnname.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.pnname.Location = new System.Drawing.Point(121, 69);
            this.pnname.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnname.Name = "pnname";
            this.pnname.Size = new System.Drawing.Size(284, 34);
            this.pnname.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 29);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // pnemail
            // 
            this.pnemail.Controls.Add(this.cmemail);
            this.pnemail.Enabled = false;
            this.pnemail.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.pnemail.Location = new System.Drawing.Point(585, 26);
            this.pnemail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnemail.Name = "pnemail";
            this.pnemail.Size = new System.Drawing.Size(247, 34);
            this.pnemail.TabIndex = 0;
            // 
            // cmemail
            // 
            this.cmemail.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmemail.FormattingEnabled = true;
            this.cmemail.Location = new System.Drawing.Point(0, 0);
            this.cmemail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmemail.Name = "cmemail";
            this.cmemail.Size = new System.Drawing.Size(203, 30);
            this.cmemail.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.panel3.Location = new System.Drawing.Point(121, 110);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 34);
            this.panel3.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker2.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(261, 29);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // btndetail
            // 
            this.btndetail.BackColor = System.Drawing.Color.Fuchsia;
            this.btndetail.ForeColor = System.Drawing.Color.White;
            this.btndetail.Location = new System.Drawing.Point(367, 10);
            this.btndetail.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btndetail.Name = "btndetail";
            this.btndetail.Size = new System.Drawing.Size(113, 43);
            this.btndetail.TabIndex = 0;
            this.btndetail.Text = "ព័ត៌មានលំអិត";
            this.btndetail.UseVisualStyleBackColor = false;
            this.btndetail.Click += new System.EventHandler(this.btndetail_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(244, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 43);
            this.button3.TabIndex = 0;
            this.button3.Text = "លុបព័ត៌មាន ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(121, 12);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(113, 43);
            this.btnupdate.TabIndex = 0;
            this.btnupdate.Text = "កែព័ត៌មាន";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // pnid
            // 
            this.pnid.Controls.Add(this.txtid);
            this.pnid.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.pnid.Location = new System.Drawing.Point(121, 28);
            this.pnid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnid.Name = "pnid";
            this.pnid.Size = new System.Drawing.Size(284, 34);
            this.pnid.TabIndex = 0;
            // 
            // txtid
            // 
            this.txtid.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtid.Location = new System.Drawing.Point(0, 0);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(261, 29);
            this.txtid.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Green;
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(4, 12);
            this.btnadd.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(113, 43);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "បង្កើតថ្មី";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // chemail
            // 
            this.chemail.AutoSize = true;
            this.chemail.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.chemail.Location = new System.Drawing.Point(445, 26);
            this.chemail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chemail.Name = "chemail";
            this.chemail.Size = new System.Drawing.Size(80, 32);
            this.chemail.TabIndex = 1;
            this.chemail.Text = "បុគ្គលិក";
            this.chemail.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.panel2.Location = new System.Drawing.Point(0, 218);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 367);
            this.panel2.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Size = new System.Drawing.Size(840, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "អត្តលេខ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "ថ្ងៃកត់ត្រា";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "ថ្ងែចំណាយ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "ថ្លៃសរុប";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "ឈ្មោះបុក្គលិក";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btndetail);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 157);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 61);
            this.panel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btnfind);
            this.groupBox1.Controls.Add(this.chdob);
            this.groupBox1.Controls.Add(this.chname);
            this.groupBox1.Controls.Add(this.chid);
            this.groupBox1.Controls.Add(this.chemail);
            this.groupBox1.Controls.Add(this.pnname);
            this.groupBox1.Controls.Add(this.pnemail);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.pnid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Khmer OS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.groupBox1.Size = new System.Drawing.Size(840, 157);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ស្វែងរក";
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Khmer OS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Expense";
            this.Text = "Expense";
            this.pnname.ResumeLayout(false);
            this.pnemail.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnid.ResumeLayout(false);
            this.pnid.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.CheckBox chdob;
        private System.Windows.Forms.CheckBox chname;
        private System.Windows.Forms.CheckBox chid;
        private System.Windows.Forms.Panel pnname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnemail;
        private System.Windows.Forms.ComboBox cmemail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btndetail;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Panel pnid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.CheckBox chemail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}