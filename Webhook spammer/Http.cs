using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net;


namespace AutoBuild
{
    class Http
    {
        public static byte[] Post(string url, NameValueCollection pairs)
        {
            using (WebClient Webclient = new WebClient())
            {


                return Webclient.UploadValues(url, pairs);



                                

            }
        }
    }
}
