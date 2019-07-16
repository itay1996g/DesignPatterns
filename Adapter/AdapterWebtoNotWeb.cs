using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdapterWebToNotWeb : IDBWebData
    {
        IDBData store = new PerfectStore();

        public void Store(WebClientData c)
        {
            ClientData data = new ClientData(c.name, c.ID);
            store.Store(data);
        }
    }
}
