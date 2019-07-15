using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRepo
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
