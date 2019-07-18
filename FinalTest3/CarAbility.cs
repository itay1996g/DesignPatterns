using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest3
{
    public class CarAbility : ICarAbility
    {
        public string StartDriving()
        {
            return "Start Driving";
        }

        public string EndDriving()
        {
            return "End Driving";
        }

        public string Speed()
        {
            return "Speed";
        }

        public string Slow()
        {
            return "Slow";
        }

        public string Right()
        {
            return "Right";
        }

        public string Left()
        {
            return "Left";
        }

        public string GasStatus()
        {
            return "Gas Status";
        }

        public string Location()
        {
            return "Location";
        }
    }
}
