using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Library.Connection
{
    class WebConnection
    {

        static WebClient webClient;
        static string baseUrl= "http://127.0.0.1:5000/";


        private WebConnection()
        {
            
        }

        public static WebClient getWebClient()
        {
            if (webClient == null)
            {
                webClient = new WebClient();
                webClient.BaseAddress = baseUrl;
            }
            return webClient;
        }




        

    }
}
