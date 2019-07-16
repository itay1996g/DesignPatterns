using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ClientData
    {
        public string name;
        public int ID;

        public ClientData(string name, int ID)
        {
            this.name = name;
            this.ID = ID;
        }

        public override string ToString()
        {
            return $"Client Data: Name: {name} ID: {ID}";
        }
    }
}
