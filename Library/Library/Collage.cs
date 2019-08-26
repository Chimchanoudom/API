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
    public partial class Collage : Form
    {
        public Collage()
        {
            InitializeComponent();
        }
        UserControl addsearch(String item)
        {
            UserControl UC = null;
          switch (item)
            {
                case "BorrowBook":
                    UC = new BorrowBook();
                    UC.Dock = System.Windows.Forms.DockStyle.Fill;
                    UC.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    UC.Location = new System.Drawing.Point(0, 0);
                    UC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                    UC.Name = "borrowBook1";
                    UC.TabIndex = 0;
                    break;
                case "ReturnBook":
                    UC = new ReturnBookC();
                    UC.Dock = System.Windows.Forms.DockStyle.Fill;
                    UC.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    UC.Location = new System.Drawing.Point(0, 0);
                    UC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                    UC.Name = "ReturnBook1";
                    UC.TabIndex = 0;
                    break;
                case "ImportBook":
                    UC = new importBookc();
                    UC.Dock = System.Windows.Forms.DockStyle.Fill;
                    UC.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    UC.Location = new System.Drawing.Point(0, 0);
                    UC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                    UC.Name = "ReturnBook1";
                    UC.TabIndex = 0;
                    break; 
                  
            }

            if (UC != null&&(PnSearch.Height>UC.Height|| PnSearch.Height < UC.Height))
            {
                PnSearch.Size = new Size(PnSearch.Width, UC.Height);
            }
            return UC;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String item = comboBox2.SelectedItem.ToString();
            item = item.Replace(" ", "");
            foreach (UserControl temp in PnSearch.Controls)
            {
                PnSearch.Controls.Remove(temp);
            }
            PnSearch.Controls.Add(addsearch(item));
           // PnSearch.Size = addsearch(item).Size;

        }
    }
}
