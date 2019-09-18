using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Class
{
  public  class buildURL
    {
        static string local = "http://127.0.0.1:5000/";
        public static string  creatUrl(string suffixurl)
        {
            string url = "";
            url =  local+ suffixurl;
            return url;
        }
    }
}
