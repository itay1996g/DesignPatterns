using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    public class Mergesort : ISort
    {
        public void Sort(IList<int> list)
        {
            Console.WriteLine("Mergesort");
        }
    }
}
