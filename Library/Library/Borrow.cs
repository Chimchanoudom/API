using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Class;

namespace Library
{
    public partial class Borrow : Form
    {
        
        public Borrow()
        {
            InitializeComponent();

        }
        addborrow abr;
        private void btnadd_Click(object sender, EventArgs e)
        {
            abr = new addborrow();
            abr.Text = "Add";
            mdi.main(encapulation.Parent1, abr,abr.Text);
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            abr = new addborrow(new List<object> { });
            abr.Text = "Update";
            mdi.main(encapulation.Parent1, abr,abr.Text);
        }

        private void btndetail_Click(object sender, EventArgs e)
        {
            Borrow_detail brd = new Borrow_detail();
            mdi.main(encapulation.Parent1, brd);
        }
    }
}
