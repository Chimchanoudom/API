using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Class
{
    class mdi
    {
        public static void main(Form Parent, Form chile)
        {
            int i = 0;
            if (Parent.MdiChildren.Length == 0)
            {
                chile.MdiParent = Parent;
                chile.Show();
                chile.WindowState = FormWindowState.Normal;

            }
            else
            {
                foreach (Form frm in Parent.MdiChildren)
                {
                    if (frm.Name == chile.Name)
                    {
                        frm.Activate();
                        return;
                        i++;
                    }
                }
                if (i == 0)
                {
                    chile.MdiParent = Parent;
                        chile.Show();
                        chile.WindowState = FormWindowState.Normal;
                    
                }
                
            }
        }
        public static void main(Form Parent, Form chile , String NameChile)
        {
            int i = 0;
            if (Parent.MdiChildren.Length == 0)
            {
                chile.MdiParent = Parent;
                chile.Show();
                chile.WindowState = FormWindowState.Normal;

            }
            else
            {
                foreach (Form frm in Parent.MdiChildren)
                {
                    if (frm.Name == chile.Name&&frm.Text==NameChile)
                    {
                        frm.Activate();
                        return;
                        i++;
                    }
                }
                if (i == 0)
                {
                    chile.MdiParent = Parent;
                    chile.Show();
                    chile.WindowState = FormWindowState.Normal;

                }

            }
        }
    }
}
