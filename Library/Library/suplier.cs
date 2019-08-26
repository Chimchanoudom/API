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
    public partial class suplier : Form
    {
        public suplier()
        {
            InitializeComponent();
        }
        Addsupplier addsuplier;
        private void btnadd_Click(object sender, EventArgs e)
        {
            addsuplier = new Addsupplier();
            addsuplier.Text = "Add";
            mdi.main(encapulation.Parent1,addsuplier,addsuplier.Text);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            addsuplier = new Addsupplier(new List<object>() { });
            addsuplier.Text = "Update";
            mdi.main(encapulation.Parent1, addsuplier, addsuplier.Text);
        }
    }
}
