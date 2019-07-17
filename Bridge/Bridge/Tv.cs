using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Tv : EnterDevice
    {
        public override void PressNext()
        {
            if (state + 1 <= maxState)
            {
                state++;
            }
            else
            {
                state = 1;
            }
        }

        public override void PressPrevious()
        {
            if (state - 1 > 0)
            {
                state--;
            }
            else
            {
                state = maxState;
            }
        }

        public override void PrintStatus()
        {
            Console.WriteLine($"TV state : {state}\n On\\Off: {isOn}\n\n");
        }
    }
}