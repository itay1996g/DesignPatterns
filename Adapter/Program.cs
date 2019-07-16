using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDBWebData adapter = new AdapterWebToNotWeb();
            WebClientData webClientData = new WebClientData("ynet.co.il", 209, "180.180.180.180", true);
            StoreClient(adapter, webClientData);
            
        }

        static void StoreClient(IDBWebData d, WebClientData c)
        {
            d.Store(c);
        }
    }
}
