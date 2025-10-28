using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    public class Truck : Vechile
    {
        public double InitFuel;
        public double MaxFuel { get; set; }
        public double FuelForKm { get; set; }
        public Truck(double initFuel, double fuelForKm, double maxFuel)
        {
            if (maxFuel > 0)
            {
                InitFuel = initFuel;
                MaxFuel = maxFuel;
            }
            else
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            FuelForKm = fuelForKm;
        }
        public override void Drive(double distance)
        {
            if (distance * FuelForKm > InitFuel)
            {
                Console.WriteLine("Truck needs refueling");
            }
            else
            {
                InitFuel -= distance * FuelForKm;
                Console.WriteLine($"Truck travelled {distance} km");
            }
        }
        public override void Refuel(double fuel)
        {
              InitFuel += fuel - (fuel * 0.05);
        }
    }
}
