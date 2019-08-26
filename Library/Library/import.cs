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
    public partial class import : Form
    {
        public import()
        {
            InitializeComponent();
        }
        addimport adddimport;
        private void btnadd_Click(object sender, EventArgs e)
        {
            adddimport = new addimport();
            adddimport.Text = "Add";
            mdi.main(encapulation.Parent1, adddimport,adddimport.Text);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            adddimport = new addimport(new List<object>() { });
            adddimport.Text = "Update";
            mdi.main(encapulation.Parent1, adddimport,adddimport.Text);
        }

        private void btndetails_Click(object sender, EventArgs e)
        {
            importdetail import_d = new importdetail();
            mdi.main(encapulation.Parent1, import_d);
        }
    }
}
