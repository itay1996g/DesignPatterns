using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaDecorator
{
    public interface IFormula
    {
        string GetFormula();
        double GetResult();

    }
}
