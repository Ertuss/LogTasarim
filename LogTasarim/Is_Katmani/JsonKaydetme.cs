using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace LogToplayıcı.Uygulama_Katmani
{
    public class JsonKaydetme
    {
        public void dosyayaYaz(List<object> jsonList,string dosya_yolu)
        {
            ////İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            //FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);

            //File.AppendAllText(dosya_yolu, "{\"" + parametreAdi + "\":\"" + parametreDeger + "\"}" + Environment.NewLine);

            var jsonStr = "{" + string.Join(",", jsonList) + "}";
            File.AppendAllText(dosya_yolu, jsonStr + Environment.NewLine);
        }




    }

}
