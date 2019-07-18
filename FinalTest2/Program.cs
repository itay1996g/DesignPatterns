using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest2
{
    class Program
    {
        static bool isEven(Component c)
        {
            if (c.GetChilds() == null && c.num % 2 == 0)
                return true;
            else if (c.num % 2 != 0)
                return false;
            return isEven(c.GetChilds()[0]) && isEven(c.GetChilds()[1]);
        }

        static void Main(string[] args)
        {
            Component root = new Composite(4);
            Component circle1 = new Leaf(2);
            Component rectangle = new Leaf(2);

            root.AddChild(circle1);
            root.AddChild(rectangle);

            // Checking sum function
            int sum = root.Sum();
            Console.WriteLine(sum);

            // Checking isEven function
            bool a = isEven(root);
            Console.WriteLine(a);

        }
    }
}
