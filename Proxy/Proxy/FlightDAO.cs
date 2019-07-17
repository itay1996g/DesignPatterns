using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class FlightDAO
    {
        internal void InsertTicket(string ticket)
        {
            Console.WriteLine($"Ticket {ticket} now in DB");
        }

        internal void GetTickets()
        {
            Console.WriteLine("SELECT * tickets FROM DB");
        }

        internal void InsertFlight(string flight)
        {
            Console.WriteLine($"INSERT {flight} INTO DB");
        }

        internal void RemoveFlight(string flight)
        {
            Console.WriteLine($"REMOVE {flight} FROM DB");
        }

        internal void InsertCustomer(string customer)
        {
            Console.WriteLine($"INSERT {customer} INTO DB");
        }

        internal void InsertCompany(string company)
        {
            Console.WriteLine($"INSERT {company} INTO DB");
        }
    }
}
