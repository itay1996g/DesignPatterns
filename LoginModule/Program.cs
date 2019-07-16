using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginModule
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context();
            NewLogin startState = new NewLogin(ctx);
            ctx.Init(startState);
            Console.WriteLine("Enter your password:");
            string userPassword = Console.ReadLine();
            ctx.Login(userPassword);
            ctx.Login(userPassword);
            ctx.Login(userPassword);
            ctx.Login(userPassword);
            ctx.Restart();
            Console.WriteLine("Enter your password:");
            userPassword = Console.ReadLine();
            ctx.Login(userPassword);

        }
    }
}
