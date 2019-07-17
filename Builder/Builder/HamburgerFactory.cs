using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HamburgerFactory
    {
        public Hamburger Create(string type)
        {
            if (type.Equals("Double"))
            {
                return PrepareHamburger(new DoubleHamburgerBuilder());
            }
            else if (type.Equals("Veg"))
            {
                return PrepareHamburger(new VeggHamburgerBuilder());
            }

            throw new ArgumentException($"sorry {type} is not in menu");
        }
        public Hamburger PrepareHamburger(HamburgerBuilder builder)
        {
            builder.BuildHamburger();
            return builder.GetHamburger();

        }

    }
}
