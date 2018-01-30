using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EbayScraperConsole
{


    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://www.ebay.com/sch/i.html?_from=R40&_trksid=p2380057.m570.l1311.R1.TR12.TRC2.A0.H0.Xxbox.TRS0&_nkw=xbox+one&_sacat=0";
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url);

            Console.WriteLine(html.Result);
            Console.ReadLine(); // to slow the world down
        }
    }
}
