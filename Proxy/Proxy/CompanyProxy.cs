using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class CompanyProxy : ClientProxy, ICompany
    {
        public void CancelFlight(string flight)
        {
            FlightSystemFacade f = new FlightSystemFacade();
            f.CancelFlight(flight);
        }

        public void CreateFlight(string flight)
        {
            FlightSystemFacade f = new FlightSystemFacade();
            f.CreateFlight(flight);
        }
    }
}
