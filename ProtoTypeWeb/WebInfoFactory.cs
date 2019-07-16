using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeWeb
{
    public class WebInfoFactory
    {
        Dictionary<string, WebInfo> webDictionary = new Dictionary<string, WebInfo>();


        public WebInfo CreateWebInfo(string url)
        {
            if (this.webDictionary.ContainsKey(url))
            {
                return webDictionary[url].clone();
            }

            WebInfo newWebInfo = new WebInfo(url);
            this.webDictionary.Add(url, newWebInfo);
            return newWebInfo;            
            
        }

    }
}
