using System;
using System.Net;
using System.Diagnostics;

namespace labs_65_web_streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            //read a web page 
            Uri bbcNews01 = new Uri("https://www.bbc.co.uk/news");

            //URI Uniform resource identifier - more general pointer
            //URL Uniform resource locator - more specific pointer

            Console.WriteLine(bbcNews01.Host);
            Console.WriteLine(bbcNews01.Port);
            Console.WriteLine(bbcNews01.AbsolutePath);

            //download this file

            var s = new Stopwatch();
            s.Start();
            GetWebPageSync();
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);

            var t = new Stopwatch();
            t.Start();
            GetWebPageAsync();
            t.Stop();
            Console.WriteLine(t.ElapsedMilliseconds);

            Console.ReadLine();
        }


        static void GetWebPageSync()
        {
            var downloadWebPage01 = new WebClient { Proxy = null };
            var momentum = new Uri("https://www.momentumsports.co.uk");
            downloadWebPage01.DownloadFile(momentum, "momentumsports.html");
            Process.Start("chrome.exe", "momentumsports.html");
        }
        async static void GetWebPageAsync()
        {
            var downloadWebPage01 = new WebClient { Proxy = null };
            var momentum = new Uri("https://www.momentumsports.co.uk");
            await downloadWebPage01.DownloadFileTaskAsync(momentum, "momentumsports.html");
            Process.Start("chrome.exe", "momentumsports.html");
        }
    }
}
