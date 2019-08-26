namespace Library
{
    partial class staff
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.chdob = new System.Windows.Forms.CheckBox();
            this.chname = new System.Windows.Forms.CheckBox();
            this.chid = new System.Windows.Forms.CheckBox();
            this.chemail = new System.Windows.Forms.CheckBox();
            this.pndob = new System.Windows.Forms.Panel();
            this.dtdob = new System.Windows.Forms.DateTimePicker();
            this.pnname = new System.Windows.Forms.Panel();
            this.cmname = new System.Windows.Forms.ComboBox();
            this.pnemail = new System.Windows.Forms.Panel();
            this.cmemail = new System.Windows.Forms.ComboBox();
            this.pnid = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndetails = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.pndob.SuspendLayout();
            this.pnname.SuspendLayout();
            this.pnemail.SuspendLayout();
            this.pnid.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnfind);
            this.groupBox1.Controls.Add(this.chdob);
            this.groupBox1.Controls.Add(this.chname);
            this.groupBox1.Controls.Add(this.chid);
            this.groupBox1.Controls.Add(this.chemail);
            this.groupBox1.Controls.Add(this.pndob);
            this.groupBox1.Controls.Add(this.pnname);
            this.groupBox1.Controls.Add(this.pnemail);
            this.groupBox1.Controls.Add(this.pnid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Khmer OS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1016, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ស្វែងរក";
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnfind.Font = new System.Drawing.Font("Khmer OS", 12F);
            this.btnfind.ForeColor = System.Drawing.Color.White;
            this.btnfind.Location = new System.Drawing.Point(608, 70);
            this.btnfind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(124, 52);
            this.btnfind.TabIndex = 0;
            this.btnfind.Text = "ស្វែងរក";
            this.btnfind.UseVisualStyleBackColor = false;
            // 
            // chdob
            // 
            this.chdob.AutoSize = true;
            this.chdob.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.chdob.Location = new System.Drawing.Point(7, 102);
            this.chdob.Name = "chdob";
            this.chdob.Size = new System.Drawing.Size(111, 32);
            this.chdob.TabIndex = 1;
            this.chdob.Text = "ថ្ងៃខែកំណើត";
            this.chdob.UseVisualStyleBackColor = true;
            // 
            // chname
            // 
            this.chname.AutoSize = true;
            this.chname.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.chname.Location = new System.Drawing.Point(7, 64);
            this.chname.Name = "chname";
            this.chname.Size = new System.Drawing.Size(118, 32);
            this.chname.TabIndex = 1;
            this.chname.Text = "ឈ្មោះបុគ្គលិក";
            this.chname.UseVisualStyleBackColor = true;
            // 
            // chid
            // 
            this.chid.AutoSize = true;
            this.chid.Checked = true;
            this.chid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chid.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.chid.Location = new System.Drawing.Point(7, 26);
            this.chid.Name = "chid";
            this.chid.Size = new System.Drawing.Size(85, 32);
            this.chid.TabIndex = 1;
            this.chid.Text = "អត្ថលេខ";
            this.chid.UseVisualStyleBackColor = true;
            // 
            // chemail
            // 
            this.chemail.AutoSize = true;
            this.chemail.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.chemail.Location = new System.Drawing.Point(464, 27);
            this.chemail.Name = "chemail";
            this.chemail.Size = new System.Drawing.Size(138, 32);
            this.chemail.TabIndex = 1;
            this.chemail.Text = "សារអេឡិចត្រូនិច";
            this.chemail.UseVisualStyleBackColor = true;
            // 
            // pndob
            // 
            this.pndob.Controls.Add(this.dtdob);
            this.pndob.Enabled = false;
            this.pndob.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.pndob.Location = new System.Drawing.Point(146, 105);
            this.pndob.Name = "pndob";
            this.pndob.Size = new System.Drawing.Size(270, 29);
            this.pndob.TabIndex = 0;
            // 
            // dtdob
            // 
            this.dtdob.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtdob.Location = new System.Drawing.Point(0, 0);
            this.dtdob.Name = "dtdob";
            this.dtdob.Size = new System.Drawing.Size(254, 29);
            this.dtdob.TabIndex = 0;
            // 
            // pnname
            // 
            this.pnname.Controls.Add(this.cmname);
            this.pnname.Enabled = false;
            this.pnname.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.pnname.Location = new System.Drawing.Point(146, 69);
            this.pnname.Name = "pnname";
            this.pnname.Size = new System.Drawing.Size(270, 30);
            this.pnname.TabIndex = 0;
            // 
            // cmname
            // 
            this.cmname.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmname.FormattingEnabled = true;
            this.cmname.Location = new System.Drawing.Point(0, 0);
            this.cmname.Name = "cmname";
            this.cmname.Size = new System.Drawing.Size(188, 30);
            this.cmname.TabIndex = 0;
            // 
            // pnemail
            // 
            this.pnemail.Controls.Add(this.cmemail);
            this.pnemail.Enabled = false;
            this.pnemail.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.pnemail.Location = new System.Drawing.Point(607, 30);
            this.pnemail.Name = "pnemail";
            this.pnemail.Size = new System.Drawing.Size(307, 32);
            this.pnemail.TabIndex = 0;
            // 
            // cmemail
            // 
            this.cmemail.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmemail.FormattingEnabled = true;
            this.cmemail.Location = new System.Drawing.Point(0, 0);
            this.cmemail.Name = "cmemail";
            this.cmemail.Size = new System.Drawing.Size(261, 30);
            this.cmemail.TabIndex = 1;
            // 
            // pnid
            // 
            this.pnid.Controls.Add(this.txtid);
            this.pnid.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.pnid.Location = new System.Drawing.Point(146, 30);
            this.pnid.Name = "pnid";
            this.pnid.Size = new System.Drawing.Size(270, 29);
            this.pnid.TabIndex = 0;
            // 
            // txtid
            // 
            this.txtid.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtid.Location = new System.Drawing.Point(0, 0);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(188, 29);
            this.txtid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btndetails);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 63);
            this.panel1.TabIndex = 1;
            // 
            // btndetails
            // 
            this.btndetails.BackColor = System.Drawing.Color.Fuchsia;
            this.btndetails.ForeColor = System.Drawing.Color.White;
            this.btndetails.Location = new System.Drawing.Point(399, 6);
            this.btndetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndetails.Name = "btndetails";
            this.btndetails.Size = new System.Drawing.Size(124, 52);
            this.btndetails.TabIndex = 0;
            this.btndetails.Text = "ព័ត៌មានលំអិត";
            this.btndetails.UseVisualStyleBackColor = false;
            this.btndetails.Click += new System.EventHandler(this.btndetails_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(267, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 52);
            this.button3.TabIndex = 0;
            this.button3.Text = "លុបព័ត៌មាន ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(135, 6);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(124, 52);
            this.btnupdate.TabIndex = 0;
            this.btnupdate.Text = "កែព័ត៌មាន";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Green;
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(3, 6);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(124, 52);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "បង្កើតថ្មី";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Khmer OS", 10F);
            this.panel2.Location = new System.Drawing.Point(0, 219);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 339);
            this.panel2.TabIndex = 2;
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
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
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
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 339);
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
            this.Column2.HeaderText = "ឈ្មោះបុគ្គលិក";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "ភេទ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "ថ្ងៃខែកំណើត";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "លេខទូរស័ព្ទ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "អាសយដ្ឋាន";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "រូបភាព";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "សារអេឡិចត្រូនិច";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 558);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "staff";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pndob.ResumeLayout(false);
            this.pnname.ResumeLayout(false);
            this.pnemail.ResumeLayout(false);
            this.pnid.ResumeLayout(false);
            this.pnid.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.CheckBox chdob;
        private System.Windows.Forms.CheckBox chname;
        private System.Windows.Forms.CheckBox chid;
        private System.Windows.Forms.CheckBox chemail;
        private System.Windows.Forms.Panel pndob;
        private System.Windows.Forms.DateTimePicker dtdob;
        private System.Windows.Forms.Panel pnname;
        private System.Windows.Forms.ComboBox cmname;
        private System.Windows.Forms.Panel pnemail;
        private System.Windows.Forms.ComboBox cmemail;
        private System.Windows.Forms.Panel pnid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btndetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}