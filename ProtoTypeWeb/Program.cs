using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] urls = { "https://github.com/rudida247/DesignPatterns", "https://www.google.co.il/?hl=iw", "https://www.facebook.com/" ,"https://github.com/rudida247/DesignPatterns", "https://www.google.co.il/?hl=iw", "https://www.facebook.com/" };
            WebInfoFactory webInfoFactory = new WebInfoFactory();
            foreach(string url in urls)
            {
                Console.WriteLine(webInfoFactory.CreateWebInfo(url).ToString());
            }
            Console.ReadLine();
        }
    }
}
