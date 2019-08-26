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
    public partial class Expireandpenalty : Form
    {
        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        public Expireandpenalty()
        {
            InitializeComponent();
            
            btn.HeaderText = "សង";
            btn.Text = "សង";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
        }

        private void Expireandpenalty_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = dataGridView1.Rows[0].Index;
            //string s = (string)dataGridView1.Rows[i].Cells[5].Value;
            //MessageBox.Show(s);
            returnbook rb = new returnbook();
            mdi.main(encapulation.Parent1, rb);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.Columns["សង"].ToString());
        }
    }
}
