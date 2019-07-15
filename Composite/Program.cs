using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static bool isBinary(Component c)
        {
            if (c.GetChilds() != null && c.GetChilds().Count != 2 && c.GetChilds().Count != 0)
                return false;
            else if (c.GetChilds() == null || c.GetChilds().Count == 0)
                return true;
            else
                return isBinary(c.GetChilds()[0]) && isBinary(c.GetChilds()[1]);
        }
        static void Main(string[] args)
        {
            Component root = new Composite("Canvas root");
            Component circle1 = new Leaf("Circle 1");
            Component rectangle = new Leaf("Rectangle x");
            root.AddChild(circle1);
            root.AddChild(rectangle);

            Component container1 = new Composite("Container 1");
            Component circle2 = new Leaf("Circle 1");
            Component circle3 = new Leaf("Circle 2");
            container1.AddChild(circle2);
            container1.AddChild(circle3);

            root.AddChild(container1);

            Component container2 = new Composite("Container of triangles");
            Component t1 = new Leaf("Triangle 1");
            Component t2 = new Leaf("Triangle 2");
            container2.AddChild(t1);
            container2.AddChild(t2);

            root.AddChild(container2);

            Component container3 = new Composite("Container of triangles");
            Component t3 = new Leaf("Triangle 3");
            Component t4 = new Leaf("Triangle 4");
            container3.AddChild(t3);
            container3.AddChild(t4);

            root.AddChild(container3);

            root.Draw("");

            Console.WriteLine();
            int leafs = root.countLeaf();
            Console.WriteLine(leafs);

            Console.WriteLine();
            bool isBin = isBinary(root);

            if (isBin)
                Console.WriteLine("Tree is Binary");
            else
                Console.WriteLine("Tree is no binary");


        }
    }
}