using Library.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            encapulation.Parent1 = this;
            //MessageBox.Show(encapt.Parent.ToString());

        }

        private void សមជកStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Expireandpenalty ep = new Expireandpenalty();
            mdi.main(this, ep);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            lbldate.Text = "កាលបរិច្ឆេទ / Date : " + dt.ToString("dddd dd - MMMM- yyyy  hh:mm  ");
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {

            Borrow br = new Borrow();
            mdi.main(this, br);
            br.WindowState = FormWindowState.Normal;
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            returnbook rb = new returnbook();
            mdi.main(this, rb);
            rb.WindowState = FormWindowState.Normal;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            student st = new student();
            mdi.main(this, st);
            st.WindowState = FormWindowState.Normal;
        }

        private void btnPrintCard_Click(object sender, EventArgs e)
        {
            printcard pc = new printcard();
            mdi.main(this, pc);
            pc.WindowState = FormWindowState.Normal;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            staff sf = new staff();
            mdi.main(this, sf);
            sf.WindowState = FormWindowState.Normal;
        }

        private void btnSupplierInformatiomn_Click(object sender, EventArgs e)
        {
            suplier suplier = new suplier();
            mdi.main(this, suplier);
        }

        private void btnprevilageanduser_Click(object sender, EventArgs e)
        {
            User_and_Privilage up = new User_and_Privilage();
            mdi.main(this, up);
            up.WindowState = FormWindowState.Normal;
        }

        private void btnImportBook_Click(object sender, EventArgs e)
        {
            import im = new import();
            mdi.main(this, im);
            im.WindowState = FormWindowState.Normal;
        }

        private void btnexpense_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            mdi.main(this, expense);
        }

        private void btnexpensetype_Click(object sender, EventArgs e)
        {
            addexpense_type expensetype = new addexpense_type();
            mdi.main(this, expensetype);
        }

        private void btnaddbook_Click(object sender, EventArgs e)
        {
            book book=new book();
            mdi.main(this,book);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Restart();
        }

        private void btnrole_Click(object sender, EventArgs e)
        {
            Role_and_privilage user = new Role_and_privilage();
            mdi.main(this, user);
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            Stock st = new Stock();
            mdi.main(this, st);
        }

        private void btncollege_Click(object sender, EventArgs e)
        {
            Collage cl = new Collage();
            mdi.main(this, cl);
        }

        private void btncollegeType_Click(object sender, EventArgs e)
        {
            collectType ct = new collectType();
            mdi.main(this, ct);
        }
    }
}
