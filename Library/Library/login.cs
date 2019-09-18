using Library.WebAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data;

namespace Library
{
    public partial class login : Form
    {
        static User us = new User();
        public login()
        {
            InitializeComponent();
            
            txtpasswd.UseSystemPasswordChar = true;
            
        }
        List<String> listKey = new List<string>();
        List<String> listValue = new List<string>();
        string reqBody;
        Object[] json;
        private void button1_Click(object sender, EventArgs e)
        {
           if(txtpasswd.Text!=null&& txtuser.Text != null)
            {
                Object[] js = { listKey, listValue };
                json = js;
                listKey.AddRange(new string[] { "name", "passwd" });
                listValue.AddRange(new string[] { txtuser.Text, txtpasswd.Text });
                if (loginclass.checklogin(json) == 1)
                {
                    MessageBox.Show("Success Login");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Fail Login");
                }
            }
            else
            {
                MessageBox.Show("Please input user name and password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtpasswd.UseSystemPasswordChar == true)
            {
                txtpasswd.UseSystemPasswordChar = false;
                btnshow.Text = "Hide";
            }
            else
            {
                txtpasswd.UseSystemPasswordChar = true;
                btnshow.Text = "Show";
            }
        }
    }
}
