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
    public partial class printcard : Form
    {
        public printcard()
        {
            InitializeComponent();
        }
        Addprintcard addprintcard;
        private void btnadd_Click(object sender, EventArgs e)
        {
            addprintcard = new Addprintcard();
            addprintcard.Text = "Add";
            mdi.main(encapulation.Parent1,addprintcard,addprintcard.Text);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            addprintcard = new Addprintcard(new List<object>() { });
            addprintcard.Text = "Update";
            mdi.main(encapulation.Parent1, addprintcard,addprintcard.Text);
        }

        private void btndetails_Click(object sender, EventArgs e)
        {
            printcard_details print_detail = new printcard_details();
            mdi.main(encapulation.Parent1, print_detail);
        }
    }
}
