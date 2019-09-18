using Library.Data;
using Library.WebAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class addstudent : Form
    {
        convertimage ci = new convertimage();
        public addstudent()
        {
            InitializeComponent();
            destination=ci.getdirectory("img\\Student\\");
        }
        List<Object> data = new List<object>();
        public addstudent(List<object>data)
        {
            InitializeComponent();
            this.data = data;
        }
        string path;
        string destination;string filename;
        Image img;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg)|*.jpg; *.jpeg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                img = new Bitmap(open.FileName);
                // image file path  
                path = open.FileName;
                filename = destination + Path.GetFileName(open.FileName);
            }
        }
        static student st;
        private void btnok_Click(object sender, EventArgs e)
        {

            if (data.Count == 1)
            {
                Object[] js = { studentdata.listKey, studentdata.listValue };
                studentdata.json = js;
                User us = new User();
                string image = filename;
                image = image.Replace("\\", "\\\\");
                studentdata.listKey.AddRange(new string[] { "name", "sex", "dob", "phone", "email", "address", "photo", "createDate", "createBy" });
                studentdata.listValue.AddRange(new string[] { txtname.Text, cmsex.SelectedItem.ToString(), dtdob.Value.ToString("yyyy-MM-dd"), txtphone.Text, txtemail.Text, txtaddress.Text, image, DateTime.Now.ToString("yyyy-MM-dd"), us.Id.ToString() });
                ci.copyimage(path, destination);
            }
            else
            {
                Object[] js = { studentdata.listKey, studentdata.listValue };
                studentdata.json = js;
                User us = new User();
                string image = filename;
                image = image.Replace("\\", "\\\\");
                studentdata.listKey.AddRange(new string[] { "name", "sex", "dob", "phone", "email", "address", "photo", "createDate", "createBy" });
                studentdata.listValue.AddRange(new string[] { txtname.Text, cmsex.SelectedItem.ToString(), dtdob.Value.ToString("yyyy-MM-dd"), txtphone.Text, txtemail.Text, txtaddress.Text, image, DateTime.Now.ToString("yyyy-MM-dd"), us.Id.ToString() });
                ci.copyimage(path, destination);
                if (studentdata.insert() == 1)
                {
                    st = new student();
                    st.refresh();
                }
                else
                {
                    MessageBox.Show("Insert Fail");
                }
            }

        }
    }
}
