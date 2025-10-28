using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    public class Bus:Vechile
    {
        public double InitFuel;
        public double MaxFuel { get; set; }
        public double FuelForKm { get; set; }
        public Bus(double initFuel, double fuelForKm,double maxFuel)
        {
            if (maxFuel > 0)
            {
                InitFuel = initFuel;
                MaxFuel = maxFuel;
            }else 
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            FuelForKm = fuelForKm;
        }
        public void Drive(double distance, bool isEmpty)
        {
            if (isEmpty)
            {
                if (distance * FuelForKm > InitFuel)
                {
                    Console.WriteLine("Bus needs refueling");
                }
                else
                {
                    InitFuel -= distance * FuelForKm;
                    Console.WriteLine($"Bus travelled {distance} km");
                }
            }else
            {
                if (distance * (FuelForKm + 1.4) > InitFuel)
                {
                    Console.WriteLine("Bus needs refueling");
                }
                else
                {
                    InitFuel -= distance * (FuelForKm + 1.4);
                    Console.WriteLine($"Bus travelled {distance} km");
                }
            }
        }
        public override void Refuel(double fuel)
        {
            if (fuel <= MaxFuel - InitFuel)
            {
                InitFuel += fuel;
            }
            else 
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
        }
    }
}
