using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Caoweb
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Crawl_web crawl_Web = new Crawl_web();
            crawl_Web.Crawlweb("shounen-ai",2);
        }
       
    }

    public class Crawl_web
    {
        public void Crawlweb(string theloai, int pageNumber)
        {

            using (WebClient webclient = new WebClient())
            {
                webclient.Headers["User-Agent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/117.0.0.0 Safari/537.36";
                webclient.Headers["Accept"] = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7";
                webclient.Headers["Accept-Language"] = "vi,fr-FR;q=0.9,fr;q=0.8,en-US;q=0.7,en;q=0.6";
                webclient.Headers["Cookie"] = "_gid=GA1.2.1046253455.1701343406; ASP.NET_SessionId=egeltoqttvglsiwlpe35enox; _ga_4X7L3HYB4K=GS1.1.1701343406.10.1.1701343518.0.0.0; _ga=GA1.1.29081782.1699348815";
                webclient.Headers["Referer"] = "https://www.nettruyenus.com/tim-truyen/shounen-ai";
                webclient.Headers["Sec-Ch-Ua"] = "Google Chrome\";v=\"117\", \"Not;A=Brand\";v=\"8\", \"Chromium\";v=\"117\"";
                webclient.Headers["Sec-Ch-Ua-Platform"] = "Windows";
                webclient.Headers["Sec-Fetch-Dest"] = "document";
                webclient.Headers["Sec-Fetch-Mode"] = "navigate";
                webclient.Headers["Sec-Fetch-Site"] = "same-origin";
                webclient.Headers["Upgrade-Insecure-Requests"] = "1";
                webclient.Headers["Sec-Fetch-User"] = "?1";
                webclient.Headers["Cache-Control"] = "max-age=0";
                webclient.Headers["Accept-Encoding"] = "gzip, deflate, br";
                webclient.Encoding = Encoding.UTF8;
                var html = webclient.DownloadString($"https://www.nettruyenus.com/tim-truyen/{theloai}?page={pageNumber}");
            }

            //using (WebClient web = new WebClient())
            //{
            //    web.Headers["User-Agent"] = "\r\nMozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/117.0.0.0 Safari/537.36";
            //   var html = web.DownloadString($"https://blogtruyen.vn/{page}");
            //}
        }
    }

}
