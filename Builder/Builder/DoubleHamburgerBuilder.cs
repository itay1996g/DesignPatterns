using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class DoubleHamburgerBuilder : HamburgerBuilder
    {
        protected override void PrepareBun()
        {
            hamburger.PrepareBun("Healthy flour");
        }

        protected override void PrepareMain()
        {
            hamburger.PrepareMain("two burgers");
        }

        protected override void PrepareTopping()
        {
            hamburger.PrepareTopping("onion");
        }

        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("Tomato and cucumber");
        }

        protected override void PreparePriceLabel()
        {
            hamburger.PreparePriceLabel("Today sale - 75 ILS");
        }
    }
}