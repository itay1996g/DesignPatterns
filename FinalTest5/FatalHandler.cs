using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest5
{
    public class FatalHandler : LoggerHandler
    {
        private string msg;

        public override void Handle(string msg, int level)
        {
            if (level == 1)
            {
                this.msg = msg;
                Console.WriteLine($"Fatal Error: {msg}");
                Console.WriteLine($"Writing message to file simulation");
                SendSMS sms = new SendSMS();
                sms.send();
            }
            if (next != null)
                next.Handle(msg, level);
        }
        public override void Read()
        {
            Console.WriteLine($"Fatal Error: {this.msg}");

            if (next != null)
                next.Read();

        }
    }
}