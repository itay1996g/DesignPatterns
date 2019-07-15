using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRepo
{
    public abstract class LoggerHandler
    {
        protected LoggerHandler next;
        public abstract void Handle(string msg, int level);
        public void SetNext(LoggerHandler next)
        {
            this.next = next;
        }

        public abstract void Read();
    }
}
