using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Unwrap
{
    class UnwrapData : IUnwrappable
    {

        /// <summary>
        /// Class for unwrap a single value from json
        /// </summary>
        /// <param name="data">Json data</param>


        private UnwrapData()
        {

        }

        private static UnwrapData unwrapData;

        public static UnwrapData GetUnwrapData()
        {
            if (unwrapData == null)
            {
                unwrapData = new UnwrapData();
            }
            return unwrapData;
        }

        public object unwrap(params object[] dataJson)
        {
            List<Dictionary<string, object>> dataList =
               JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(dataJson[0] + "");

            string result;
            foreach (Dictionary<string, object> row in dataList)
            {
                foreach (string key in row.Keys)
                {
                    result = row[key] + "";
                    return result;
                }
            }
            return null;
        }
    }
}
