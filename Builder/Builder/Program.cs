using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HamburgerBuilder> menu = new List<HamburgerBuilder>();
            menu.Add(new VeggHamburgerBuilder());
            menu.Add(new VeggHambBuilderLettuce());
            menu.Add(new DoubleHamburgerBuilder());

            Hamburger hamb = PrepareHamburger(menu[0]);
            Hamburger hamb2 = PrepareHamburger(menu[2]);
            Console.WriteLine(hamb2.ToString());

            HamburgerFactory fac = new HamburgerFactory();
            fac.Create("Double");
            Console.WriteLine(fac.ToString());
        }

        static Hamburger PrepareHamburger(HamburgerBuilder builder)
        {
            builder.BuildHamburger();
            return builder.GetHamburger();
        }
    }
}