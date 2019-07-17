using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyFactory
    {
        public ClientProxy Login(string username, string pw)
        {
            if (username == "Admin" && pw == "Admin")
            {
                ClientProxy adminProxy = new AdminProxy();
                return adminProxy;
            }
            if (username == "Company" && pw == "Company")
            {
                ClientProxy CompanyProxy = new CompanyProxy();
                return CompanyProxy;
            }
            if (username == "Customer" && pw == "Customer")
            {
                ClientProxy CustomerProxy = new CustomerProxy();
                return CustomerProxy;
            }

            throw new Exception("Credentials are not valid!");
            
        }
    }
}
