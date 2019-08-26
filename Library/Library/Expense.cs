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
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }
        addexpense addexpense;

        private void btnadd_Click(object sender, EventArgs e)
        {
            addexpense = new addexpense();
            addexpense.Text = "Add";
            mdi.main(encapulation.Parent1, addexpense,addexpense.Text);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            addexpense = new addexpense(new List<object>() { });
            addexpense.Text = "Update";
            mdi.main(encapulation.Parent1, addexpense,addexpense.Text);
        }

        private void btndetail_Click(object sender, EventArgs e)
        {
            expense_detail expense_d = new expense_detail();
            mdi.main(encapulation.Parent1, expense_d);
        }

    }
}
