using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ShopRent : IVisitable
    {

        public double price = 1000;

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
