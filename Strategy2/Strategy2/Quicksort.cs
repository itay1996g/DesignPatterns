using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    public class Quicksort : ISort
    {
        public void Sort(IList<int> list)
        {
            Console.WriteLine("Quicksort");
        }
    }
}
