using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class BadStore : IDBWebData
    {
        public void Store(WebClientData c)
        {
            Console.WriteLine("Store is bad");
        }
    }
}
