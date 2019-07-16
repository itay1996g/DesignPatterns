using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PerfectStore : IDBData
    {
        public void Store(ClientData c)
        {
            Console.WriteLine($"Store is perfect {c.ToString()}");
        }
    }
}
