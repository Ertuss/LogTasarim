using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace LogToplayıcı.Is_Katmani
{
    public class Diagnostic
    {

        public static void SiemensDiagnostikVeriGetir()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://192.168.41.10/ClientArea/ASLog.csv");
            request.Referer = "http://192.168.41.10//Portal/Portal.mwsl?PriNav=Diag";
            request.AllowAutoRedirect = true;
            request.Method = "GET";
            String test = String.Empty;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                test = reader.ReadToEnd();
                Console.WriteLine(test);
                reader.Close();
                dataStream.Close();
            }
        }


    }

}
