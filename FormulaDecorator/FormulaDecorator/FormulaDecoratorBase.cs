using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaDecorator
{
    public abstract class FormulaDecoratorBase  : IFormula
    {
        protected IFormula form;

        public abstract string GetFormula();
        public abstract double GetResult();

        public FormulaDecoratorBase(IFormula form)
        {
            this.form = form;
        }

    }
}
