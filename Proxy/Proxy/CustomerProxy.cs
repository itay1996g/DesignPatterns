using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class CustomerProxy : ClientProxy, ICustomer
    {
        public void BuyTicket(string ticket)
        {
            FlightSystemFacade f = new FlightSystemFacade();
            f.BuyTicket(ticket);
        }

        public void ShowMyTickets()
        {
            FlightSystemFacade f = new FlightSystemFacade();
            f.ShowMyTickets();
        }
    }
}
