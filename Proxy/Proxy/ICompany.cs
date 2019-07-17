using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface ICompany
    {
        void CreateFlight(string flight);
        void CancelFlight(string flight);
    }
}
