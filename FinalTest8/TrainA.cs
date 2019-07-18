using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest8
{
    public class TrainA : GymTrainBase
    {
        protected override void Execute()
        {
            Console.WriteLine("Doing A Train");
        }
    }
}