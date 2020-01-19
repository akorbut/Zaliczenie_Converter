using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ExchangeLesson
{
    class DataOperations
    {
        public JToken HttpGet(string baseCur)
        {
            var c = new HttpClient();

            string res;
            if (baseCur != null)
            {
                res = c.GetStringAsync("https://api.exchangeratesapi.io/latest?base=" +
                                               baseCur).Result;
                return JObject.Parse(res)["rates"];
            }

            res = c.GetStringAsync("https://api.exchangeratesapi.io/latest?base=PLN").Result;
            return JObject.Parse(res)["rates"];
        }

        public double Convert(double currency, double amount)
        {
            return currency * amount;
        }
    }
}
