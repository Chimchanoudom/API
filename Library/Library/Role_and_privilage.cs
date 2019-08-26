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
    public partial class Role_and_privilage : Form
    {
        public Role_and_privilage()
        {
            InitializeComponent();
        }

        public static implicit operator Role_and_privilage(User_and_Privilage v)
        {
            throw new NotImplementedException();
        }
    }
}
