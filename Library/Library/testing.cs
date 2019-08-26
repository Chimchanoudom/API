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
    public partial class testing : Form
    {
        public testing()
        {
            InitializeComponent();
        }

        private void testing_Load(object sender, EventArgs e)
        {
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (RadioButton rnd in flowLayoutPanel1.Controls)
            //{
            //    if (rnd.Checked == true)
            //    {
            //        MessageBox.Show(rnd.Text);
            //        break;
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
      
        {
            MessageBox.Show(""+usercontrol_testing1.ComboName.SelectedItem+usercontrol_testing1.DateBorrow.Value+usercontrol_testing1.DateReturn.Value);
        }
    }
}
