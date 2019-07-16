using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WebClientData 
    {
        public string name;
        public int ID;
        public string IP;
        public bool SSL;

        public WebClientData(string name, int ID, string IP, bool SSL) 
        {
            this.ID = ID;
            this.name = name;
            this.IP = IP;
            this.SSL = SSL;
        }

    }
}