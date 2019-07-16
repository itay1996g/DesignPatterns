using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopRent shop = new ShopRent();

            Console.WriteLine(shop);

            IVisitor shekel = new OneShekelSale();

            Console.WriteLine($"Price after tax = {shop.Accept(shekel)}");

            
        }
    }
}