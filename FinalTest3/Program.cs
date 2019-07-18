using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            LimitedFuncProxy client = new LimitedFuncProxy();
            string gas = client.GasStatus();
            string location = client.Location();
            Console.WriteLine($"gas: {gas},   location: {location}");
        }
    }
}
