using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Class
{
    class encapulation
    {
        static Form Parent;

        public static Form Parent1
        {
            get { return encapulation.Parent; }
            set { encapulation.Parent = value; }
        }
    }
}
