using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterDevice tv = new Tv();
            EnterDevice memir = new Memir();

            tv.PrintStatus();
            memir.PrintStatus();

            RemoteControl rc = new RemoteControl(memir);
            rc.On();
            rc.Previous();
            rc.Next();
            rc.Next();
            memir.PrintStatus();

            rc.Device = tv;
            rc.On();
            rc.Previous();
            rc.Previous();
            rc.Next();
            tv.PrintStatus();
        }
    }
}