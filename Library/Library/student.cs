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
using Library.WebAPI;

namespace Library
{
    public partial class student : Form
    {
        public  student()
        {
            InitializeComponent();
            refresh();

        }
       public student(string s="")
        {
            InitializeComponent();
        }
        addstudent addstudent;
        private void btnadd_Click(object sender, EventArgs e)
        {
            addstudent = new addstudent();
            addstudent.Text = "Add";
            mdi.main(encapulation.Parent1, addstudent,addstudent.Text);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            addstudent = new addstudent(new List<object>() { });
            addstudent.Text = "Update";
            mdi.main(encapulation.Parent1, addstudent,addstudent.Text);
        }

        private void btndetail_Click(object sender, EventArgs e)
        {
            
        }
        public void getdata()
        {
           
            studentdata.getall();
            
           
        }
        public void refresh()
        {
            studentdata.dt.Columns.Clear();
            studentdata.dt.Rows.Clear();
            foreach (DataGridViewColumn i in dgvStudent.Columns)
            {
                if (i.HeaderText == "រូបភាព")
                {
                    studentdata.dt.Columns.Add(i.HeaderText, typeof(Image));
                }
                else
                {
                    studentdata.dt.Columns.Add(i.HeaderText);
                }
            }
            dgvStudent.Columns.Clear();
            dgvStudent.DataSource = studentdata.dt;
           // ((DataGridViewImageColumn)dgvStudent.Columns["រូបភាព"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

        }
        private void student_Load(object sender, EventArgs e)
        {
            getdata();
            dgvStudent.ClearSelection();
        }
    }
}
