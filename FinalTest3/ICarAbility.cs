using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest3
{
    public interface ICarAbility
    {
        string StartDriving();

        string EndDriving();

        string Speed();

        string Slow();

        string Right();

        string Left();

        string GasStatus();

        string Location();
    }
}
