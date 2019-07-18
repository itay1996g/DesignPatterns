using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest4
{
    public class MultBy2 : IOperation
    {
        public void Operate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = arr[i] * 2;

            foreach (int i in arr)
                Console.WriteLine(i + " ");
        }


    }
}
