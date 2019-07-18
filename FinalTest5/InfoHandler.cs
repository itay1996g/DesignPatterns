using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest5
{
    class InfoHandler : LoggerHandler
    {
        private string msg;
        public override void Handle(string msg, int level)
        {
            if (level == 3)
            {
                this.msg = msg;
                Console.WriteLine($"Info: {msg}");

            }
            if (next != null)
                next.Handle(msg, level);
        }
        public override void Read()
        {
            Console.WriteLine($"Info: {this.msg}");
            if (next != null)
                next.Read();
        }

    }
}