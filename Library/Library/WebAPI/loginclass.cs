using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.WebAPI;
using Library.Request;
using Library.Wrap;
using Library.Unwrap;
using Library.Class;
using Library.Data;

namespace Library.WebAPI
{
   public static class loginclass
    {
       static RequestHepler rqh = RequestHepler.getRequestHepler();
        static JSONWrapper wrapper = JSONWrapper.getJSONWrapper();
        static UnwrapRows unwrapRows = UnwrapRows.getUnwrapRows();
        static UnwrapData unwrapData = UnwrapData.GetUnwrapData();
        static User us = new User();


        public static int checklogin(Object[]json)
        {
            int message;
            
         string js = wrapper.wrap(json)+"";
            List<Dictionary<string, object>> data = rqh.postDataByRequest(buildURL.creatUrl("login"), js);
            if (data.Count > 0)
            {
                foreach (Dictionary<string, object> itm in data)
                {
                    //new User((int)itm["userid"], itm["username"].ToString(), itm["password"].ToString(), itm["is_Active"].ToString(), itm["staffname"].ToString(),itm["rolename"].ToString());
                    us.Id = int.Parse( itm["userid"]+"");
                    us.Username = itm["username"].ToString();
                    us.Password = itm["password"].ToString();
                    us.Is_active = itm["is_Active"].ToString();
                    us.Staffname = itm["staffname"].ToString();
                    us.Roleid = itm["rolename"].ToString();
                }
                message = 1;
            }
            else
            {
                message = 0;
            }


            return message;
        }
    }
   
}
