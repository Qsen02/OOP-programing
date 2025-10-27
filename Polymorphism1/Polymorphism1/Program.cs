using System.Data;

namespace Polymorphism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] carLine=Console.ReadLine().Split(" ");
            Vechile car = new Car(double.Parse(carLine[1]), double.Parse(carLine[2]));
            string[] truckLine = Console.ReadLine().Split(" ");
            Vechile truck = new Truck(double.Parse(truckLine[1]), double.Parse(truckLine[2]));
            int commandCount=int.Parse(Console.ReadLine());
            List<string> commands=new List<string>();
            for (int i = 0; i < commandCount; i++) 
            {
                commands.Add(Console.ReadLine());
            }
            foreach (string command in commands) 
            {
                string[] commandLine=command.Split(" ");
                string commandType=commandLine[0];
                if (commandType == "Drive")
                {
                    string vechileType=commandLine[1];
                    if (vechileType == "Car")
                    {
                        car.Drive(double.Parse(commandLine[2]));
                    }
                    else 
                    {
                        truck.Drive(double.Parse(commandLine[2]));
                    }
                }
                else 
                {
                    string vechileType = commandLine[1];
                    if (vechileType == "Car")
                    {
                        car.Refuel(double.Parse(commandLine[2]));
                    }
                    else
                    {
                        truck.Refuel(double.Parse(commandLine[2]));
                    }
                }
            }
            Console.WriteLine($"Car: {car.Fuel:F2)}");
            Console.WriteLine($"Truck: {truck.Fuel:F2)}");
        }
    }
}
