using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Autosalon
{
    public static class APIClass
    {
        public static double temp;
        public static Dictionary<string, double> vals = new Dictionary<string, double>();

        public static void Weather()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Ulyanovsk%2C%20ULY%2C%20RU/today?unitGroup=metric&include=days%2Ccurrent&key=NL2J7AV7AARDN4WK2BQ6R7L42&contentType=json");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);

            string sReadData = sr.ReadToEnd();
            response.Close();

            dynamic w = JsonConvert.DeserializeObject(sReadData);
            string temper;
            temper = w.days[0].temp.ToString();
            temp = Convert.ToDouble(temper);
        }

        public static void Vals()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.cbr-xml-daily.ru/daily_json.js");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);

            string sReadData = sr.ReadToEnd();
            response.Close();

            dynamic v = JsonConvert.DeserializeObject(sReadData);

            string usd = v.Valute.USD.Value.ToString();
            string eur = v.Valute.EUR.Value.ToString();
            string cny = v.Valute.CNY.Value.ToString();

            double Usd = Convert.ToDouble(usd);
            double Eur = Convert.ToDouble(eur);
            double Cny = Convert.ToDouble(cny);

            vals.Add("Рубли", 1);
            vals.Add("Доллары", Usd);
            vals.Add("Евро", Eur);
            vals.Add("Юани", Cny);
        }
    }
}
