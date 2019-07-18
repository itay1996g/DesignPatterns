using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest4
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int[] a = new int[5] { 1, 3, 5, 2, 8 };
            NewArray arr = new NewArray(a);

            Console.WriteLine("Enter 1 for sort | Enter 2 for Mult");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            arr.Operate(input);

            
        }
    }
}
