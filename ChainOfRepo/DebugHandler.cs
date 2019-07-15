using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRepo
{
    class DebugHandler : LoggerHandler
    {
        private string msg;
        public override void Handle(string msg, int level)
        {
            if (level == 4)
            {
                this.msg = msg;
                Console.WriteLine($"Debug: {msg}");
            }
            if (next != null)
                next.Handle(msg, level);

        }
        public override void Read()
        {
            Console.WriteLine($"Debug Message: {this.msg}");
            if (next != null)
                next.Read();
        }

    }
}
