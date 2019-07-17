using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class RemoteControl
    {
        public EnterDevice Device { get; set; }

        public RemoteControl(EnterDevice device)
        {
            this.Device = device;
        }

        public void On()
        {
            Device.TurnOn();
        }

        public void Off()
        {
            Device.TurnOff();
        }

        public void Next()
        {
            Device.PressNext();
        }

        public void Previous()
        {
            Device.PressPrevious();
        }
    }
}