using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.WebAPI
{
  public   class convertimage
    {
        public string getdirectory(string suffixpath)
        {
            string s = "";
            s = Directory.GetCurrentDirectory();
            string[] dir = s.Split('\\');
            s = "";
            for (int i = 0; i < dir.Length - 2; i++)
            {
                s += dir[i] + "\\";
            }
            s += suffixpath;
            if (Directory.Exists(s))
            {
                return s;
            }
            else
            {
                Directory.CreateDirectory(s);
                return s;
            }


        }
        public void copyimage(string path, string dis)
        {
            if (path != null && dis != null)
            {
                File.Copy(path, dis + Path.GetFileName(path), true);
            }
        }
        public Image getimage(string distin)
        {
            Image img = null;
            if (distin != "")
                img = Image.FromFile(distin);
            else
                img = Properties.Resources.noimage;
            return img;
        }
    }
}
