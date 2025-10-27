using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    public class Car: Vechile
    {
        public double Fuel { get; set; }
        public double FuelForKm { get; set; }
        public Car(double fuel,double fuelForKm) 
        {
            Fuel = fuel;
            FuelForKm = fuelForKm + 0.9;
        }
        public override void Drive(double distance) 
        {
            if (distance * FuelForKm > Fuel)
            {
                Console.WriteLine("Car needs refueling");
            }
            else 
            {
                Fuel-=distance*FuelForKm;
                Console.WriteLine($"Car travelled {distance} km");
            }
        }
        public override void Refuel(double fuel)
        {
            Fuel += fuel;
        }
    }
}
