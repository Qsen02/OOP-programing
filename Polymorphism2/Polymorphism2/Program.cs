using System.Data;
using System.Diagnostics;

namespace Polymorphism2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] carLine = Console.ReadLine().Split(" ");
            Car car = new Car(double.Parse(carLine[1]), double.Parse(carLine[2]), double.Parse(carLine[3]));
            string[] truckLine = Console.ReadLine().Split(" ");
            Truck truck = new Truck(double.Parse(truckLine[1]), double.Parse(truckLine[2]), double.Parse(truckLine[3]));
            string[] busLine = Console.ReadLine().Split(" ");
            Bus bus = new Bus(double.Parse(busLine[1]), double.Parse(busLine[2]), double.Parse(busLine[3]));
            int commandCount = int.Parse(Console.ReadLine());
            List<string> commands= new List<string>();
            for (int i = 0; i < commandCount; i++)
            {
                commands.Add(Console.ReadLine());
            }
            foreach (string command in commands)
            {
                string[] commandLine = command.Split(" ");
                string commandType = commandLine[0];
                if (commandType == "Drive")
                {
                    string vechileType = commandLine[1];
                    if (vechileType == "Car")
                    {
                        car.Drive(double.Parse(commandLine[2]));
                    }
                    else if (vechileType == "Truck")
                    {
                        truck.Drive(double.Parse(commandLine[2]));
                    }
                    else
                    {
                        bus.Drive(double.Parse(commandLine[2]), false);
                    }
                }
                else if (commandType == "Refuel")
                {
                    string vechileType = commandLine[1];
                    if (vechileType == "Car")
                    {
                        car.Refuel(double.Parse(commandLine[2]));
                    }
                    else if (vechileType == "Truck")
                    {
                        truck.Refuel(double.Parse(commandLine[2]));
                    }
                    else 
                    {
                        bus.Refuel(double.Parse(commandLine[2]));
                    }
                }
                else 
                {
                    bus.Drive(double.Parse(commandLine[2]), true);
                }
            }
            Console.WriteLine($"Car: {car.InitFuel:F2}");
            Console.WriteLine($"Truck: {truck.InitFuel:F2}");
            Console.WriteLine($"Bus: {bus.InitFuel:F2}");
        }
    }
}
