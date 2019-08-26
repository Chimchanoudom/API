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
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }
        AddStaff addstaff;
        private void btnadd_Click(object sender, EventArgs e)
        {
            addstaff = new AddStaff();
            mdi.main(encapulation.Parent1, addstaff);
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            addstaff = new AddStaff(new List<object>() { });
            mdi.main(encapulation.Parent1, addstaff);
        }

        private void btndetails_Click(object sender, EventArgs e)
        {

        }
    }
}
