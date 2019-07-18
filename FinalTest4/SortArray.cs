using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest4
{
    public class SortArray : IOperation
    {
        public void Operate(int[] arr)
        {
            Console.WriteLine("Sort Array simulation");

            foreach (int i in arr)
                Console.WriteLine(i + " ");

        }
    }
}
