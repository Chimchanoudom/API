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
    public partial class book : Form
    {
        public book()
        {
            InitializeComponent();
        }
        addbook addbook;
        private void btnadd_Click(object sender, EventArgs e)
        {
            addbook = new addbook();
            addbook.Text = "Add";
            mdi.main(encapulation.Parent1, addbook,addbook.Text);
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            addbook = new addbook(new List<object>() { });
            addbook.Text = "Update";
            mdi.main(encapulation.Parent1, addbook,addbook.Text);
        }
    }
}
