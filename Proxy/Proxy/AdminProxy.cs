using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class AdminProxy : ClientProxy, IAdmin
    {
        public void CreateCompany(string company)
        {
            FlightSystemFacade f = new FlightSystemFacade();
            f.CreateCompany(company);
        }

        public void CreateCustomer(string customer)
        {
            FlightSystemFacade f = new FlightSystemFacade();
            f.CreateCustomer(customer);
        }
    }
}
