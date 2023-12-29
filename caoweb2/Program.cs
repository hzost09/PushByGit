using HtmlAgilityPack;
using System;
using System.Net.Http;
using System.Text;

namespace caoweb2
{
    class Caoweb
    {
        static async Task Main(string[] args)
        {
            String url = "https://empirecapital.vn/";
            var http = new HttpClient();
            http.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537");
            var html = await http.GetStringAsync(url);
            var htmldocument = new HtmlDocument();
            htmldocument.OptionDefaultStreamEncoding = Encoding.UTF8;
            htmldocument.LoadHtml(html);
          
        }
    }
}
