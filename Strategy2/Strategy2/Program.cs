using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberCollection a = new NumberCollection();
            a.Add(1);
            a.Sort();
            a.Add(2);
            a.Sort();
            a.Add(3);
            a.Add(4);
            a.Add(5);
            a.Add(6);
            a.Add(7);
            a.Add(8);
            a.Add(9);
            a.Add(10);
            a.Add(11);

            a.Sort();
        }
    }
}
