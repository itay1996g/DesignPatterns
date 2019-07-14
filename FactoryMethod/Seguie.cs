using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Seguie : Vehicle
    {
        protected string drivingWheelHeater;

        public Seguie(string model, float cylinder, string color, int numberOfWheels, string drivingWheelHeater) : base(model, cylinder, color, numberOfWheels)
        {
            this.drivingWheelHeater = drivingWheelHeater;
        }

        public override string ToString()
        {
            return "Seguie " + base.ToString() + $" {drivingWheelHeater}";
        }
    }
}