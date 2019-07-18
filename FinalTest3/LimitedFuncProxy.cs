using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest3
{
    public class LimitedFuncProxy : ILimitedFunc
    {
        CarAbility car = new CarAbility();

        public string GasStatus()
        {
            return car.GasStatus();
        }

        public string Location()
        {
            return car.Location();
        }
    }
}
