using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormula form = new StartNumber(5);

            
            IFormula multToNumber = new Mult(form, 2);
            Console.WriteLine(multToNumber.GetFormula() + " = " + multToNumber.GetResult());
            IFormula addToNumber = new Add(multToNumber, 100);
            Console.WriteLine(addToNumber.GetFormula() + " = " + addToNumber.GetResult());
            IFormula divideToNumber = new Divide(addToNumber, 12);
            Console.WriteLine(divideToNumber.GetFormula() + " = " + divideToNumber.GetResult());
            IFormula subToNumber = new Sub(divideToNumber, 3);
            Console.WriteLine(subToNumber.GetFormula() + " = " + subToNumber.GetResult());
            IFormula mult2ToNumber = new Mult(subToNumber, 4);
            Console.WriteLine(mult2ToNumber.GetFormula() + " = " + mult2ToNumber.GetResult());
            IFormula add2ToNumber = new Add(mult2ToNumber, 7);
            Console.WriteLine(add2ToNumber.GetFormula() + " = " + add2ToNumber.GetResult());


        }
    }
}
