namespace Library
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.សវភBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBorrowBook = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFindbook = new System.Windows.Forms.ToolStripMenuItem();
            this.សមជកStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintCard = new System.Windows.Forms.ToolStripMenuItem();
            this.បគគលកStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.btnprevilageanduser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnrole = new System.Windows.Forms.ToolStripMenuItem();
            this.អនកភផគតផគងSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSupplierInformatiomn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportBook = new System.Windows.Forms.ToolStripMenuItem();
            this.btnaddbook = new System.Windows.Forms.ToolStripMenuItem();
            this.btnstock = new System.Windows.Forms.ToolStripMenuItem();
            this.របយករណReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnexpense = new System.Windows.Forms.ToolStripMenuItem();
            this.btnexpensetype = new System.Windows.Forms.ToolStripMenuItem();
            this.btnexit = new System.Windows.Forms.ToolStripMenuItem();
            this.បទបញជToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btncollege = new System.Windows.Forms.ToolStripMenuItem();
            this.btncollegeType = new System.Windows.Forms.ToolStripMenuItem();
            this.របយករណToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.របយករណចណលIncomeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ចណលពករខចសវភToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ចណលពករផកពនយToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ចណលពករបពមភបណធToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.របយករណចណយToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ចណយលករទញសវភToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ចណយផសងៗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Khmer OS Muol Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.សវភBookToolStripMenuItem,
            this.សមជកStudentToolStripMenuItem,
            this.បគគលកStaffToolStripMenuItem,
            this.អនកភផគតផគងSupplierToolStripMenuItem,
            this.របយករណReportToolStripMenuItem,
            this.btnexit,
            this.បទបញជToolStripMenuItem,
            this.របយករណToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1230, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // សវភBookToolStripMenuItem
            // 
            this.សវភBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBorrowBook,
            this.btnReturnBook,
            this.btnFindbook});
            this.សវភBookToolStripMenuItem.Font = new System.Drawing.Font("Khmer OS Muol Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.សវភBookToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.សវភBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("សវភBookToolStripMenuItem.Image")));
            this.សវភBookToolStripMenuItem.Name = "សវភBookToolStripMenuItem";
            this.សវភBookToolStripMenuItem.Size = new System.Drawing.Size(138, 31);
            this.សវភBookToolStripMenuItem.Text = "សៀវភៅ / Book";
            this.សវភBookToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.សវភBookToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.BackColor = System.Drawing.Color.Black;
            this.btnBorrowBook.ForeColor = System.Drawing.Color.Yellow;
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(245, 28);
            this.btnBorrowBook.Text = "ខ្ចីសៀវភៅ / Borrow Book";
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.Black;
            this.btnReturnBook.ForeColor = System.Drawing.Color.Yellow;
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(245, 28);
            this.btnReturnBook.Text = "សងសៀវភៅ​ /Return Book";
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnFindbook
            // 
            this.btnFindbook.BackColor = System.Drawing.Color.Black;
            this.btnFindbook.ForeColor = System.Drawing.Color.Yellow;
            this.btnFindbook.Name = "btnFindbook";
            this.btnFindbook.Size = new System.Drawing.Size(245, 28);
            this.btnFindbook.Text = "ស្វែងរក/ Find";
            // 
            // សមជកStudentToolStripMenuItem
            // 
            this.សមជកStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegister,
            this.btnPrintCard});
            this.សមជកStudentToolStripMenuItem.Font = new System.Drawing.Font("Khmer OS Muol Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.សមជកStudentToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.សមជកStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("សមជកStudentToolStripMenuItem.Image")));
            this.សមជកStudentToolStripMenuItem.Name = "សមជកStudentToolStripMenuItem";
            this.សមជកStudentToolStripMenuItem.Size = new System.Drawing.Size(148, 31);
            this.សមជកStudentToolStripMenuItem.Text = "សមាជិក​ / Student";
            this.សមជកStudentToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.សមជកStudentToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.សមជកStudentToolStripMenuItem.Click += new System.EventHandler(this.សមជកStudentToolStripMenuItem_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.ForeColor = System.Drawing.Color.Yellow;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(199, 28);
            this.btnRegister.Text = "ចុះឈ្មោះ / Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnPrintCard
            // 
            this.btnPrintCard.BackColor = System.Drawing.Color.Black;
            this.btnPrintCard.ForeColor = System.Drawing.Color.Yellow;
            this.btnPrintCard.Name = "btnPrintCard";
            this.btnPrintCard.Size = new System.Drawing.Size(199, 28);
            this.btnPrintCard.Text = "ធ្វើបណ្ណ័ / Print Card";
            this.btnPrintCard.Click += new System.EventHandler(this.btnPrintCard_Click);
            // 
            // បគគលកStaffToolStripMenuItem
            // 
            this.បគគលកStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddStaff,
            this.btnprevilageanduser,
            this.btnrole});
            this.បគគលកStaffToolStripMenuItem.Font = new System.Drawing.Font("Khmer OS Muol Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.បគគលកStaffToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.បគគលកStaffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("បគគលកStaffToolStripMenuItem.Image")));
            this.បគគលកStaffToolStripMenuItem.Name = "បគគលកStaffToolStripMenuItem";
            this.បគគលកStaffToolStripMenuItem.Size = new System.Drawing.Size(155, 31);
            this.បគគលកStaffToolStripMenuItem.Text = "បុគ្គលិក /​ Employee";
            this.បគគលកStaffToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.បគគលកStaffToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.Black;
            this.btnAddStaff.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(355, 28);
            this.btnAddStaff.Text = "បញ្ចូលបុគ្គលិក / Add Employee";
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnprevilageanduser
            // 
            this.btnprevilageanduser.BackColor = System.Drawing.Color.Black;
            this.btnprevilageanduser.ForeColor = System.Drawing.Color.Yellow;
            this.btnprevilageanduser.Name = "btnprevilageanduser";
            this.btnprevilageanduser.Size = new System.Drawing.Size(355, 28);
            this.btnprevilageanduser.Text = "គណនី​ នឹង លេខសម្ងាត់ /  User and Password";
            this.btnprevilageanduser.Click += new System.EventHandler(this.btnprevilageanduser_Click);
            // 
            // btnrole
            // 
            this.btnrole.BackColor = System.Drawing.Color.Black;
            this.btnrole.ForeColor = System.Drawing.Color.Yellow;
            this.btnrole.Name = "btnrole";
            this.btnrole.Size = new System.Drawing.Size(355, 28);
            this.btnrole.Text = "សិទ្ធិ នឹង ការប្រើប្រាស់ / Role and Previllage";
            this.btnrole.Click += new System.EventHandler(this.btnrole_Click);
            // 
            // អនកភផគតផគងSupplierToolStripMenuItem
            // 
            this.អនកភផគតផគងSupplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSupplierInformatiomn,
            this.btnImportBook,
            this.btnaddbook,
            this.btnstock});
            this.អនកភផគតផគងSupplierToolStripMenuItem.Font = new System.Drawing.Font("Khmer OS Muol Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.អនកភផគតផគងSupplierToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.អនកភផគតផគងSupplierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("អនកភផគតផគងSupplierToolStripMenuItem.Image")));
            this.អនកភផគតផគងSupplierToolStripMenuItem.Name = "អនកភផគតផគងSupplierToolStripMenuItem";
            this.អនកភផគតផគងSupplierToolStripMenuItem.Size = new System.Drawing.Size(110, 31);
            this.អនកភផគតផគងSupplierToolStripMenuItem.Text = "ស្តុក / Stock";
            this.អនកភផគតផគងSupplierToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.អនកភផគតផគងSupplierToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // btnSupplierInformatiomn
            // 
            this.btnSupplierInformatiomn.BackColor = System.Drawing.Color.Black;
            this.btnSupplierInformatiomn.ForeColor = System.Drawing.Color.Yellow;
            this.btnSupplierInformatiomn.Name = "btnSupplierInformatiomn";
            this.btnSupplierInformatiomn.Size = new System.Drawing.Size(321, 28);
            this.btnSupplierInformatiomn.Text = "ព័ត៌មានអ្នកផ្គត់ផ្កង់ / Supplier Information";
            this.btnSupplierInformatiomn.Click += new System.EventHandler(this.btnSupplierInformatiomn_Click);
            // 
            // btnImportBook
            // 
            this.btnImportBook.BackColor = System.Drawing.Color.Black;
            this.btnImportBook.ForeColor = System.Drawing.Color.Yellow;
            this.btnImportBook.Name = "btnImportBook";
            this.btnImportBook.Size = new System.Drawing.Size(321, 28);
            this.btnImportBook.Text = "នាំចូលសៀវភៅ / Import Book";
            this.btnImportBook.Click += new System.EventHandler(this.btnImportBook_Click);
            // 
            // btnaddbook
            // 
            this.btnaddbook.BackColor = System.Drawing.Color.Black;
            this.btnaddbook.ForeColor = System.Drawing.Color.Yellow;
            this.btnaddbook.Name = "btnaddbook";
            this.btnaddbook.Size = new System.Drawing.Size(321, 28);
            this.btnaddbook.Text = "បង្កើតសៀវភៅ / Create Book";
            this.btnaddbook.Click += new System.EventHandler(this.btnaddbook_Click);
            // 
            // btnstock
            // 
            this.btnstock.BackColor = System.Drawing.Color.Black;
            this.btnstock.ForeColor = System.Drawing.Color.Yellow;
            this.btnstock.Name = "btnstock";
            this.btnstock.Size = new System.Drawing.Size(321, 28);
            this.btnstock.Text = "ស្តុក / Stock";
            this.btnstock.Click += new System.EventHandler(this.btnstock_Click);
            // 
            // របយករណReportToolStripMenuItem
            // 
            this.របយករណReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnexpense,
            this.btnexpensetype});
            this.របយករណReportToolStripMenuItem.Font = new System.Drawing.Font("Khmer OS Muol Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.របយករណReportToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.របយករណReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("របយករណReportToolStripMenuItem.Image")));
            this.របយករណReportToolStripMenuItem.Name = "របយករណReportToolStripMenuItem";
            this.របយករណReportToolStripMenuItem.Size = new System.Drawing.Size(178, 31);
            this.របយករណReportToolStripMenuItem.Text = "ការចំណាយ / Expense";
            this.របយករណReportToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.របយករណReportToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // btnexpense
            // 
            this.btnexpense.BackColor = System.Drawing.Color.Black;
            this.btnexpense.ForeColor = System.Drawing.Color.Yellow;
            this.btnexpense.Name = "btnexpense";
            this.btnexpense.Size = new System.Drawing.Size(275, 28);
            this.btnexpense.Text = "ការចំណាយ​ / Expense";
            this.btnexpense.Click += new System.EventHandler(this.btnexpense_Click);
            // 
            // btnexpensetype
            // 
            this.btnexpensetype.BackColor = System.Drawing.Color.Black;
            this.btnexpensetype.ForeColor = System.Drawing.Color.Yellow;
            this.btnexpensetype.Name = "btnexpensetype";
            this.btnexpensetype.Size = new System.Drawing.Size(275, 28);
            this.btnexpensetype.Text = "ប្រភេទចំណាយ / Expense Type";
            this.btnexpensetype.Click += new System.EventHandler(this.btnexpensetype_Click);
            // 
            // btnexit
            // 
            this.btnexit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(171, 31);
            this.btnexit.Text = "ចាកចេញ / Log out";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // បទបញជToolStripMenuItem
            // 
            this.បទបញជToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btncollege,
            this.btncollegeType});
            this.បទបញជToolStripMenuItem.Font = new System.Drawing.Font("Khmer OS Muol Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.បទបញជToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.បទបញជToolStripMenuItem.Name = "បទបញជToolStripMenuItem";
            this.បទបញជToolStripMenuItem.Size = new System.Drawing.Size(117, 31);
            this.បទបញជToolStripMenuItem.Text = "បិទបញ្ជី/College";
            // 
            // btncollege
            // 
            this.btncollege.BackColor = System.Drawing.Color.Black;
            this.btncollege.ForeColor = System.Drawing.Color.Yellow;
            this.btncollege.Name = "btncollege";
            this.btncollege.Size = new System.Drawing.Size(284, 28);
            this.btncollege.Text = "ការបិទបញ្ជី​ /  College";
            this.btncollege.Click += new System.EventHandler(this.btncollege_Click);
            // 
            // btncollegeType
            // 
            this.btncollegeType.BackColor = System.Drawing.Color.Black;
            this.btncollegeType.ForeColor = System.Drawing.Color.Yellow;
            this.btncollegeType.Name = "btncollegeType";
            this.btncollegeType.Size = new System.Drawing.Size(284, 28);
            this.btncollegeType.Text = "ប្រភេទការបិទបញ្ជី / College Type";
            this.btncollegeType.Click += new System.EventHandler(this.btncollegeType_Click);
            // 
            // របយករណToolStripMenuItem
            // 
            this.របយករណToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.របយករណចណលIncomeReportToolStripMenuItem,
            this.របយករណចណយToolStripMenuItem});
            this.របយករណToolStripMenuItem.Font = new System.Drawing.Font("Khmer OS Muol Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.របយករណToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.របយករណToolStripMenuItem.Image = global::Library.Properties.Resources.report;
            this.របយករណToolStripMenuItem.Name = "របយករណToolStripMenuItem";
            this.របយករណToolStripMenuItem.Size = new System.Drawing.Size(164, 31);
            this.របយករណToolStripMenuItem.Text = "របាយការណ៍/Report";
            // 
            // របយករណចណលIncomeReportToolStripMenuItem
            // 
            this.របយករណចណលIncomeReportToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.របយករណចណលIncomeReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ចណលពករខចសវភToolStripMenuItem,
            this.ចណលពករផកពនយToolStripMenuItem,
            this.ចណលពករបពមភបណធToolStripMenuItem});
            this.របយករណចណលIncomeReportToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.របយករណចណលIncomeReportToolStripMenuItem.Name = "របយករណចណលIncomeReportToolStripMenuItem";
            this.របយករណចណលIncomeReportToolStripMenuItem.Size = new System.Drawing.Size(323, 28);
            this.របយករណចណលIncomeReportToolStripMenuItem.Text = "របាយការណ៍ ចំណូល​/ Income Report";
            // 
            // ចណលពករខចសវភToolStripMenuItem
            // 
            this.ចណលពករខចសវភToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ចណលពករខចសវភToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.ចណលពករខចសវភToolStripMenuItem.Name = "ចណលពករខចសវភToolStripMenuItem";
            this.ចណលពករខចសវភToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.ចណលពករខចសវភToolStripMenuItem.Text = "ចំណូលពីការខ្ចីសៀវភៅ";
            // 
            // ចណលពករផកពនយToolStripMenuItem
            // 
            this.ចណលពករផកពនយToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ចណលពករផកពនយToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.ចណលពករផកពនយToolStripMenuItem.Name = "ចណលពករផកពនយToolStripMenuItem";
            this.ចណលពករផកពនយToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.ចណលពករផកពនយToolStripMenuItem.Text = "ចំណូលពីការផាកពិន័យ";
            // 
            // ចណលពករបពមភបណធToolStripMenuItem
            // 
            this.ចណលពករបពមភបណធToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ចណលពករបពមភបណធToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.ចណលពករបពមភបណធToolStripMenuItem.Name = "ចណលពករបពមភបណធToolStripMenuItem";
            this.ចណលពករបពមភបណធToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.ចណលពករបពមភបណធToolStripMenuItem.Text = "ចំណូលពីការបោះពុម្ភប័ណ្ណ";
            // 
            // របយករណចណយToolStripMenuItem
            // 
            this.របយករណចណយToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.របយករណចណយToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ចណយលករទញសវភToolStripMenuItem,
            this.ចណយផសងៗToolStripMenuItem});
            this.របយករណចណយToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.របយករណចណយToolStripMenuItem.Name = "របយករណចណយToolStripMenuItem";
            this.របយករណចណយToolStripMenuItem.Size = new System.Drawing.Size(323, 28);
            this.របយករណចណយToolStripMenuItem.Text = "របាយការណ៍ ចំណាយ​ /Expense Report";
            // 
            // ចណយលករទញសវភToolStripMenuItem
            // 
            this.ចណយលករទញសវភToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ចណយលករទញសវភToolStripMenuItem.Font = new System.Drawing.Font("Khmer OS Muol Light", 9F);
            this.ចណយលករទញសវភToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.ចណយលករទញសវភToolStripMenuItem.Name = "ចណយលករទញសវភToolStripMenuItem";
            this.ចណយលករទញសវភToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.ចណយលករទញសវភToolStripMenuItem.Text = "ចំណាយលើការទិញសៀវភៅ";
            // 
            // ចណយផសងៗToolStripMenuItem
            // 
            this.ចណយផសងៗToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ចណយផសងៗToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.ចណយផសងៗToolStripMenuItem.Name = "ចណយផសងៗToolStripMenuItem";
            this.ចណយផសងៗToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.ចណយផសងៗToolStripMenuItem.Text = "ចំណាយផ្សេងៗ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 593);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 49);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "អ្នកប្រើប្រាស់ / User  :";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Black;
            this.lbldate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbldate.Location = new System.Drawing.Point(1098, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(128, 27);
            this.lbldate.TabIndex = 3;
            this.lbldate.Text = "កាលបរិច្ឆេទ / Date :";
            this.lbldate.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1230, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Khmer OS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Form1";
            this.Text = "7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem សវភBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnBorrowBook;
        private System.Windows.Forms.ToolStripMenuItem btnReturnBook;
        private System.Windows.Forms.ToolStripMenuItem សមជកStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem បគគលកStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnFindbook;
        private System.Windows.Forms.ToolStripMenuItem btnRegister;
        private System.Windows.Forms.ToolStripMenuItem btnPrintCard;
        private System.Windows.Forms.ToolStripMenuItem btnAddStaff;
        private System.Windows.Forms.ToolStripMenuItem អនកភផគតផគងSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSupplierInformatiomn;
        private System.Windows.Forms.ToolStripMenuItem btnImportBook;
        private System.Windows.Forms.ToolStripMenuItem របយករណReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnexit;
        private System.Windows.Forms.ToolStripMenuItem btnexpense;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem btnprevilageanduser;
        private System.Windows.Forms.ToolStripMenuItem btnexpensetype;
        private System.Windows.Forms.ToolStripMenuItem btnaddbook;
        private System.Windows.Forms.ToolStripMenuItem បទបញជToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem របយករណToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btncollege;
        private System.Windows.Forms.ToolStripMenuItem btncollegeType;
        private System.Windows.Forms.ToolStripMenuItem btnstock;
        private System.Windows.Forms.ToolStripMenuItem btnrole;
        private System.Windows.Forms.ToolStripMenuItem របយករណចណលIncomeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ចណលពករខចសវភToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ចណលពករផកពនយToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ចណលពករបពមភបណធToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem របយករណចណយToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ចណយលករទញសវភToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ចណយផសងៗToolStripMenuItem;
    }
}

