using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context(new Fix());
            ctx.levelUp();
            Console.WriteLine(ctx);
            ctx.hitted();
            ctx.levelUp();

            Console.WriteLine(ctx);

            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();

            Console.WriteLine(ctx);

            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();

            Console.WriteLine(ctx);

            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();

            Console.WriteLine(ctx);

            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();

            Console.WriteLine(ctx);

            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();
            ctx.hitted();

            ctx.levelUp();
            Console.WriteLine(ctx);
            Console.ReadLine();
        }
    }
}