using Library.Class;
using Library.Request;
using Library.Unwrap;
using Library.Wrap;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WebAPI
{
    public static class studentdata
    {
        static convertimage ci = new convertimage();
        static RequestHepler rqh = RequestHepler.getRequestHepler();
        static JSONWrapper wrapper = JSONWrapper.getJSONWrapper();
        static UnwrapRows unwrapRows = UnwrapRows.getUnwrapRows();
        static UnwrapData unwrapData = UnwrapData.GetUnwrapData();
        public static DataTable dt = new DataTable();
        public static DataTable bp = new DataTable();
        public static List<String> listKey = new List<string>();
        public static List<String> listValue = new List<string>();
        public static string reqBody;
        public static Object[] json;
        public static Dictionary<string, Image> photo = new Dictionary<string, Image>();
        public static void getall( )
        {
            List<Dictionary<string, object>> data = rqh.getDataByRequest(buildURL.creatUrl("student_all"));
            if (data.Count > 0)
            {
                photo = new Dictionary<string, Image>();
                foreach(Dictionary<string, object>i in data)
                {
                    
                    dt.Rows.Add(i["studentid"].ToString(), i["name"].ToString(),
                        (i["sex"]!=null)?i["sex"].ToString():"",
                        (i["dateofbirth"]!=null)?i["dateofbirth"].ToString():"",
                        (i["phone"]!=null)?i["phone"].ToString():"",
                        (i["email"]!=null)?i["email"].ToString():"",
                        i["Address"]!=null?i["Address"].ToString():"",
                        i["photo"]==null?Properties.Resources.noimage:ci.getimage(i["photo"].ToString()),
                        (i["creatdate"]!=null)?i["creatdate"].ToString():"",
                        i["staffname"]!=null?i["staffname"].ToString():"");
                    photo.Add(i["photo"].ToString(), ci.getimage(i["photo"].ToString()));
                }
                var UniqueRows = dt.AsEnumerable().Distinct(DataRowComparer.Default);
                bp = UniqueRows.CopyToDataTable();
                dt = bp;
            }

        }
        public static int insert( )
        {
            int message;
            string js = wrapper.wrap(json) + "";
            List<Dictionary<string, object>> data = rqh.postDataByRequest(buildURL.creatUrl("student_add"),js);
            if (data.Count > 0)
            {
                photo = new Dictionary<string, Image>();
                foreach (Dictionary<string, object> i in data)
                {

                    dt.Rows.Add(i["studentid"].ToString(), i["name"].ToString(),
                        (i["sex"] != null) ? i["sex"].ToString() : "",
                        (i["dateofbirth"] != null) ? i["dateofbirth"].ToString() : "",
                        (i["phone"] != null) ? i["phone"].ToString() : "",
                        (i["email"] != null) ? i["email"].ToString() : "",
                        i["Address"] != null ? i["Address"].ToString() : "",
                        i["photo"] == null ? Properties.Resources.noimage : ci.getimage(i["photo"].ToString()),
                        (i["creatdate"] != null) ? i["creatdate"].ToString() : "",
                        i["staffname"] != null ? i["staffname"].ToString() : "");
                    photo.Add(i["photo"].ToString(), ci.getimage(i["photo"].ToString()));
                }
                var UniqueRows = dt.AsEnumerable().Distinct(DataRowComparer.Default);
                bp = UniqueRows.CopyToDataTable();
                dt = bp;
                message = 1;
            }
            else
            {
                message = 0;
            }
            return message;
        }
        public static int update()
        {
            int message;
            string js = wrapper.wrap(json) + "";
            List<Dictionary<string, object>> data = rqh.postDataByRequest(buildURL.creatUrl("student_update"), js);
            if (data.Count > 0)
            {
                photo = new Dictionary<string, Image>();
                foreach (Dictionary<string, object> i in data)
                {

                    dt.Rows.Add(i["studentid"].ToString(), i["name"].ToString(),
                        (i["sex"] != null) ? i["sex"].ToString() : "",
                        (i["dateofbirth"] != null) ? i["dateofbirth"].ToString() : "",
                        (i["phone"] != null) ? i["phone"].ToString() : "",
                        (i["email"] != null) ? i["email"].ToString() : "",
                        i["Address"] != null ? i["Address"].ToString() : "",
                        i["photo"] == null ? Properties.Resources.noimage : ci.getimage(i["photo"].ToString()),
                        (i["creatdate"] != null) ? i["creatdate"].ToString() : "",
                        i["staffname"] != null ? i["staffname"].ToString() : "");
                    photo.Add(i["photo"].ToString(), ci.getimage(i["photo"].ToString()));
                }
                var UniqueRows = dt.AsEnumerable().Distinct(DataRowComparer.Default);
                bp = UniqueRows.CopyToDataTable();
                dt = bp;
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

