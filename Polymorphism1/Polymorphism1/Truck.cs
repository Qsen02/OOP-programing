using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    public class Truck : Vechile
    {
        public double Fuel { get; set; }
        public double FuelForKm { get; set; }
        public Truck(double fuel, double fuelForKm)
        {
            Fuel = fuel;
            FuelForKm = fuelForKm + 1.6;
        }
        public override void Drive(double distance)
        {
            if (distance * FuelForKm > Fuel)
            {
                Console.WriteLine("Truck needs refueling");
            }
            else
            {
                Fuel -= distance * FuelForKm;
                Console.WriteLine($"Truck travelled {distance} km");
            }
        }
        public override void Refuel(double fuel)
        {
            Fuel += fuel-(fuel*0.05);
        }
    }
}
