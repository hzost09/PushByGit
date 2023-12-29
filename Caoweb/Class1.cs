using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Caoweb
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            var html = "https://www.nettruyenus.com/tim-truyen/shounen-ai?page=2";
            Crawl_web web = new Crawl_web();
            web.Crawlweb(html);
            File.WriteAllText("res1.text", html);
            Process.Start("res1.text");
        }
    }
    public class Crawl_web
    {
        public string Crawlweb(string url)
        {
            HttpRequest http = new HttpRequest();
            http.UserAgent = Http.ChromeUserAgent(); // Thêm UserAgent
            http.IgnoreProtocolErrors = true; // Bỏ qua lỗi giao thức
            string html = http.Get(url).ToString();          
            return html;

        }
    }
}
