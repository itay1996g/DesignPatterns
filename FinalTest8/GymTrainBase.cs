using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest8
{
    public abstract class GymTrainBase : GymTrain
    {
        protected override void ChangeClothes()
        {
            Console.WriteLine("Chainging clothes...");
        }
        protected override void DrinkWater()
        {
            Console.WriteLine("Drinking water...");
        }
        protected override void Shower()
        {
            Console.WriteLine("Taking a shower...");
        }

    }
}