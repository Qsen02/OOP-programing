using Polymorphism3.AbstractClasses;
using Polymorphism3.Animals;
using Polymorphism3.Foods;

namespace Polymorphism3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> commands= new List<string>();
           string curCommand = "";
            while (curCommand != "End") 
            {
                curCommand = Console.ReadLine();
                commands.Add(curCommand);
            }
            List<Mammal> animals = new List<Mammal>();
            List<Food> foods = new List<Food>();
            foreach (string command in commands) 
            {
                string[] commandLine = command.Split(' ');
                string commandType = commandLine[0];
                switch (commandType) 
                {
                    case "Mouse":
                        Mammal mouse = new Mouse(commandLine[0], commandLine[1], double.Parse(commandLine[2]), commandLine[3]);
                        animals.Add(mouse);
                    break;
                    case "Zebra":
                        Mammal zebra = new Zebra(commandLine[0], commandLine[1], double.Parse(commandLine[2]), commandLine[3]);
                        animals.Add(zebra);
                        break;
                    case "Tiger":
                        Mammal tiger = new Tiger(commandLine[0], commandLine[1], double.Parse(commandLine[2]), commandLine[3]);
                        animals.Add(tiger);
                        break;
                    case "Cat":
                        Mammal cat = new Cat(commandLine[0], commandLine[1], double.Parse(commandLine[2]), commandLine[3], commandLine[4]);
                        animals.Add(cat);
                        break;
                    case "Vegetable":
                        Food vegetable = new Vegetable(int.Parse(commandLine[1]));
                        foods.Add(vegetable);
                        break;
                    case "Meat":
                        Food meat = new Meat(int.Parse(commandLine[1]));
                        foods.Add(meat);
                        break;
                }
            }
            for (int i = 0; i < animals.Count; i++) 
            {
                Mammal animal= animals[i];
                Food food = foods[i];
                animal.MakeSound();
                if (food is Vegetable)
                {
                    animal.Eat("Vegetable", food.Quantity);
                }
                else 
                {
                    animal.Eat("Meat", food.Quantity);
                }
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
