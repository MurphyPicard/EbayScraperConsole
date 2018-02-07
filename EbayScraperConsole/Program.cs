using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

// Helpful link...
// https://www.youtube.com/watch?v=B4x4pnLYMWI

namespace EbayScraperConsole
{
    
    class Program
    {
        static void Main(string[] args)
        {
            GetHtmlAsync();
            Console.ReadLine(); // to slow the world down
        }

        // Commit Note: added keywords async and await
        public static async void GetHtmlAsync()
        {
            var url = "https://www.ebay.com/sch/i.html?_from=R40&_trksid=p2380057.m570.l1311.R1.TR12.TRC2.A0.H0.Xxbox.TRS0&_nkw=xbox+one&_sacat=0";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();

            // Commit Note: added keywords async and await for this to work
            htmlDocument.LoadHtml(html);

            var ProductList = htmlDocument.DocumentNode.Descendants("ul")
                .Where(node => node.GetAttributeValue("id", "").Equals("ListViewInner"))
                .ToList();

            Console.WriteLine(ProductList);

        }
    }
}
