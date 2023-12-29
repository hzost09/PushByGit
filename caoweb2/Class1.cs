using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace caoweb2
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();

        static async Task Main()
        {
            //try
            //{
            //    // Send a request to the API
            //    var html = await client.GetStringAsync("https://api.example.com/data");

            //    // Load the HTML into an HtmlDocument
            //    var htmlDocument = new HtmlDocument();
            //    htmlDocument.LoadHtml(html);

            //    // Parse the HtmlDocument
            //    var nodes = htmlDocument.DocumentNode.SelectNodes("//div[@class='example']");
            //    var data = new List<string>();
            //    foreach (var node in nodes)
            //    {
            //        data.Add(node.InnerText);
            //    }

            //    // Convert the data to JSON
            //    var json = JsonSerializer.Serialize(data);
            //    Console.WriteLine(json);
            //}
            //catch (HttpRequestException e)
            //{
            //    Console.WriteLine("\nException Caught!");
            //    Console.WriteLine("Message :{0} ", e.Message);
            //}
        }
    }
}

