using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Wrap
{
    class  JSONWrapper : IWrappable
    {

        /// <summary>
        /// Class for wrap data to json 
        /// Expected return data {"someKey": "someValue","anotherKey": "anotherValue"};
        /// </summary>
        /// <param name="data">data[0]=arrayKey for JSON,data[1]=JSON Data</param>

        public  object wrap(params object[] data)
        {
            List<String> arrayKey = (List<String>)data[0];
            List<String> arrayValue = (List<String>)data[1];

            string jsonData="";
           
            for (int i = 0; i < arrayKey.Count; i++)
            {
                jsonData += "\"" + arrayKey[i] + "\":\""+arrayValue[i]+"\",";
            }

            jsonData = "{" + jsonData.Substring(0,jsonData.Length-1) + "}";

            return jsonData;
        }

        private static JSONWrapper jsonWrapper;

        private JSONWrapper()
        {

        }

        public static JSONWrapper getJSONWrapper()
        {
            if (jsonWrapper == null)
            {
                jsonWrapper = new JSONWrapper();
            }
            return jsonWrapper;
        }
    }
}
