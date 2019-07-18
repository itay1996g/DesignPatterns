using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest8
{
    public abstract class GymTrain
    {
        protected abstract void ChangeClothes();
        protected abstract void DrinkWater();
        protected abstract void Execute();
        protected abstract void Shower();

        public void Run()
        {
            ChangeClothes();
            DrinkWater();
            Execute();
            Shower();
        }
    }
}