using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class FlightSystemFacade : IAdmin, ICompany, ICustomer
    {
        FlightDAO dao = new FlightDAO();

        public void BuyTicket(string ticket)
        {
            this.dao.InsertTicket(ticket);            
        }

        public void CancelFlight(string flight)
        {
            this.dao.RemoveFlight(flight);
        }

        public void CreateCompany(string company)
        {
            this.dao.InsertCompany(company);
        }

        public void CreateCustomer(string customer)
        {
            this.dao.InsertCustomer(customer);
        }

        public void CreateFlight(string flight)
        {
            this.dao.InsertFlight(flight);
        }

        public void ShowMyTickets()
        {
            this.dao.GetTickets();
        }
    }
}
