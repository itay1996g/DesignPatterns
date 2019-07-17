using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface IAdmin
    {
        void CreateCustomer(string customer);
        void CreateCompany(string company);
    }
}
