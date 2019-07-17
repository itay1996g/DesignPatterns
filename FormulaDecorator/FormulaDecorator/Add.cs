using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaDecorator
{
    public class Add : FormulaDecoratorBase
    {
        protected int num;
        public Add(IFormula form, int num) : base(form)
        {
            this.num = num;
        }
        public override string GetFormula()
        {
            return form.GetFormula() + $" + {this.num}";
        }

        public override double GetResult()
        {
            return form.GetResult() + this.num;
        }
    }
}
