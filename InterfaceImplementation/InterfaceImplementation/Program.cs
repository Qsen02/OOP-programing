using System.Reflection;

namespace InterfaceImplementation
{
    internal class Program
    {
        static void Task1() 
        {
            Console.WriteLine("Task 1.....");
            Type personInterface = typeof(Citizen1).GetInterface("IPerson"); 
            PropertyInfo[] properties = personInterface.GetProperties(); 
            Console.WriteLine(properties.Length); 
            string name = Console.ReadLine(); 
            int age = int.Parse(Console.ReadLine()); 
            IPerson person = new Citizen1(name, age); 
            Console.WriteLine(person.Name); 
            Console.WriteLine(person.Age);
        }
        static void Task2()
        {
            Console.WriteLine("Task 2.....");
            Type identifiableInterface = typeof(Citizen2).GetInterface("IIdentifiable"); 
            Type birthableInterface = typeof(Citizen2).GetInterface("IBirthable"); 
            PropertyInfo[] properties = identifiableInterface.GetProperties(); 
            Console.WriteLine(properties.Length); 
            Console.WriteLine(properties[0].PropertyType.Name); 
            properties = birthableInterface.GetProperties(); 
            Console.WriteLine(properties.Length); 
            Console.WriteLine(properties[0].PropertyType.Name); 
            string name = Console.ReadLine(); 
            int age = int.Parse(Console.ReadLine()); 
            string id = Console.ReadLine(); 
            string birthdate = Console.ReadLine(); 
            IIdentifiable identifiable = new Citizen2(name, age, id, birthdate);
            IBirthable birthable = new Citizen2(name, age, id, birthdate);
        }
        static void Task3() 
        {
            Console.WriteLine("Task 3.....");
            Smartphone smartphone = new Smartphone("Samsung galaxy A13");
            string[] phoneNumbers = Console.ReadLine().Split(" ");
            string[] webSites = Console.ReadLine().Split(" ");
            smartphone.Call(phoneNumbers);
            smartphone.Browse(webSites);
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
    }
}
