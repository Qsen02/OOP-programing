using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    public abstract class Vechile
    {
        public double Fuel;
        public double FuelForKm;
        public virtual void Drive(double distance) { }
        public virtual void Refuel(double fuel) { }
    }
}
