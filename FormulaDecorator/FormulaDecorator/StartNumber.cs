using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaDecorator
{
    public class StartNumber : IFormula
    {
        protected double startNum;

        public StartNumber(int start)
        {
            this.startNum = start;
        }
        public string GetFormula()
        {
            return this.startNum.ToString();
        }

        public double GetResult()
        {
            return this.startNum;
        }
    }
}
