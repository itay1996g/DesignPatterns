using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFactory factory = new ProxyFactory();

            AdminProxy admin = (AdminProxy)factory.Login("Admin", "Admin");
            CustomerProxy customer = (CustomerProxy)factory.Login("Customer", "Customer");
            CompanyProxy company = (CompanyProxy)factory.Login("Company", "Company");

            admin.CreateCompany("ELAL");
            admin.CreateCustomer("Moshe");
            customer.BuyTicket("To Italia");
            customer.ShowMyTickets();
            company.CancelFlight("To Maldives");
            company.CreateFlight("To Spain");

        }
    }
}
