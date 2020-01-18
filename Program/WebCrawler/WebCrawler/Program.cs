using System;
using HtmlAgilityPack;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace WebCrawler
{
    
    class Program
    {
        static void Main(string[] args)
        {
            startCrawlerasync();
            Console.ReadLine();
        }

        private static async Task startCrawlerasync()
        {
            var url = "https://www.kabum.com.br/cgi-local/site/listagem/listagem.cgi?string=PC+gamer&btnG=";
            var httpCliente = new HttpClient();
            var html = await httpCliente.GetStringAsync(url);
            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);

            var cars = new List<Car>();

            var divs = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("listagem-precos")).ToList();
            var divsModelo = htmlDocument.DocumentNode.Descendants("section").Where(node => node.GetAttributeValue("class", "").Equals("listagem-box")).ToList();

            foreach (var div in divs)
            {
                var car = new Car
                {
                    Price = div.Descendants("b").FirstOrDefault().InnerText,
                };
            cars.Add(car);
                
            }

           
            foreach (var div in divsModelo)
            {
                var car = new Car
                {
                    Model = div.Descendants("h2").FirstOrDefault().InnerText,
                };
                cars.Add(car);
            }

        }
    }
}
