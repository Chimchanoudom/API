using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
 public class User
    {
        static int id;
        static string username;
        static string password;
        static string is_active;
        static string roleid;
        static string staffname;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Is_active
        {
            get
            {
                return is_active;
            }

            set
            {
                is_active = value;
            }
        }

        public string Roleid
        {
            get
            {
                return roleid;
            }

            set
            {
                roleid = value;
            }
        }

        public string Staffname
        {
            get
            {
                return staffname;
            }

            set
            {
                staffname = value;
            }
        }

        public string getstaffname()
        {
            return staffname;
        }
    }
}
