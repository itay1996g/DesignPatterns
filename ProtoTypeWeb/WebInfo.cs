using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeWeb
{
    public class WebInfo: IProtoType<WebInfo>
    {
        private DateTime timeStamp;
        public string size;
        private string url;

        public WebInfo(string url)
        {
            this.timeStamp = DateTime.Now;
            this.url = url;
            this.size = getSizeUrl(url);
        }

        public WebInfo(DateTime timeStamp, string size, string url)
        {
            this.timeStamp = timeStamp;
            this.size = size;
            this.url = url;
        }

        private string getSizeUrl(string url)
        {
            Task<string> task = WriteWebRequestSizeAsync(url);

            while (!task.Wait(100))
            {
                Console.Write(".");
            }
            return task.Result;
        }

        static public string FormatBytes(long bytes)
        {
            string[] magnitudes =
                new string[] { "GB", "MB", "KB", "Bytes" };
            long max =
                (long)Math.Pow(1024, magnitudes.Length);

            return string.Format("{1:##.##} {0}",
                magnitudes.FirstOrDefault(
                    magnitude =>
                    bytes > (max /= 1024)) ?? "0 Bytes",
              (decimal)bytes / (decimal)max);
        }

        private static async Task<string> WriteWebRequestSizeAsync(string url)
        {
            try
            {
                WebRequest webRequest =
                    WebRequest.Create(url);
                WebResponse response =
                    await webRequest.GetResponseAsync();
                using (StreamReader reader =
                    new StreamReader(
                        response.GetResponseStream()))
                {
                    string text =
                        await reader.ReadToEndAsync();
                    return FormatBytes(text.Length);
                }
            }
            catch (WebException)
            {
                return "";
                // ...
            }
            catch (IOException)
            {
                return "";
                // ...
            }
            catch (NotSupportedException)
            {
                return "";
                // ...
            }
        }

        public WebInfo clone()
        {
            return new WebInfo(this.timeStamp, this.url, this.size);
        }

        public override string ToString()
        {
            return $"WebInfo, url: {url}, size: {size}, timeStamp: {timeStamp}";
        }
    }
}
