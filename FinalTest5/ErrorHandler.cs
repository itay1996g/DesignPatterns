using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest5
{
    class ErrorHandler : LoggerHandler
    {
        private string msg;
        public override void Handle(string msg, int level)
        {
            if (level == 2)
            {
                this.msg = msg;
                Console.WriteLine($"Error: {msg}");
                Console.WriteLine($"Writing message to file simulation");
            }
            if (next != null)
                next.Handle(msg, level);

        }
        public override void Read()
        {
            Console.WriteLine($"Error: {this.msg}");
            if (next != null)
                next.Read();
        }

    }
}