using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Library.Connection;
using Library.Unwrap;


namespace Library.Request
{
    class RequestHepler
    {

        static RequestHepler requestHepler;
        static WebClient webConnection = WebConnection.getWebClient();
        public string code ="";
        static string dataKey = "";
        public object data = "";
        private RequestHepler()
        {

        }

        public static RequestHepler getRequestHepler()
        {
            if (requestHepler == null)
            {
                requestHepler = new RequestHepler();
            }
            return requestHepler;
        }


        public List<Dictionary<string,object>> getDataByRequest(string endPoint)
        {
            string reqBody = "{}";
            byte[] reqByteBody = Encoding.UTF8.GetBytes(reqBody);
            byte[] result = webConnection.UploadData(endPoint,"POST",reqByteBody);
            string stResult = Encoding.UTF8.GetString(result);
            List<Dictionary<string, object>> rawJson = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(stResult);
            return rawJson;
            
        }

        public List<Dictionary<string, object>> postDataByRequest(string endPoint,string reqBody)
        {
            webConnection.Headers.Clear();
            webConnection.Headers.Add("Content-Type", "application/json");

            byte[] reqByteBody = Encoding.UTF8.GetBytes(reqBody);
            byte[] result = webConnection.UploadData(endPoint, "POST", reqByteBody);
            string stResult = Encoding.UTF8.GetString(result);


            List<Dictionary<string, object>> rawJson = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(stResult);
            return rawJson;

            //code = rawJson["CD"].ToString();

            //data = rawJson[dataKey];


        }



    }
}
