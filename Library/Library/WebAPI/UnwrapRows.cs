using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Unwrap
{
    class UnwrapRows : IUnwrappable
    {

        /// <summary>
        /// Class for unwrap datarow from json to datagridview
        /// </summary>
        /// <param name="data">data[0]=arrayKey in JSON,data[1]=JSON Data,data[2]=Datagridview to unwrap datarow to</param>
        /// <param name="data[0]">KeyList in JSON</param>
        /// <param name="data[1]">JSON Data</param>
        /// <param name="data[2]">Datagridview to unwrap datarow to</param>

        private static UnwrapRows unwrapRows;

        private UnwrapRows()
        {

        }

        public static UnwrapRows getUnwrapRows()
        {
            if (unwrapRows == null)
            {
                unwrapRows = new UnwrapRows();
            }
            return unwrapRows;
        }


        public object unwrap(params object[] data)
        {

            string[] keyList = (string[])data[0];
            string rawList = data[1] + "";

            List<Dictionary<string, object>> dataList = 
                JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(rawList);

            int keyLength;


            DataGridView dgv = (DataGridView)data[2];

            foreach (Dictionary<string, object> row in dataList)
            {
                string[] stRow = new string[keyList.Length];

                keyLength = 0;
                foreach (string key in keyList)
                {
                    stRow[keyLength] = row[key]+"";
                    keyLength++;
                }


                dgv.Rows.Add(stRow);    
            }

            return null;
        }
    }
}
