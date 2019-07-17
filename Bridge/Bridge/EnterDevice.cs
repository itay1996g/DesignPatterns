using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class EnterDevice
    {
        protected int maxState = 10;
        protected bool isOn = false;
        protected int state = 1;

        public abstract void PrintStatus();

        public abstract void PressNext();

        public abstract void PressPrevious();

        public void TurnOn()
        {
            isOn = true;
        }

        public void TurnOff()
        {
            isOn = false;
        }
    }
}