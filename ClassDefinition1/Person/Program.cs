using System.Reflection;

namespace ClassDefinition1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.......");
            Type personType = typeof(Person); 
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance); 
            Console.WriteLine(fields.Length);
            Person person1= new Person();
            person1.Name = "Pesho";
            person1.Age = 20;
            Person person2= new Person();
            person2.Name = "Gosho";
            person2.Age = 18;
            Console.WriteLine("{0} {1}", person1.Name, person1.Age);
            Console.WriteLine("{0} {1}", person2.Name, person2.Age);

            Console.WriteLine("Task 2.......");
            Console.Write("Number of lines:");
            string lines= Console.ReadLine();
            int linesNumber=int.Parse(lines);
            Family family = new Family();
            for (int i = 1; i <= linesNumber; i++) 
            {
                Person person = new Person();
                Console.WriteLine("Person {0}", i);
                Console.Write("Name:");
                string name= Console.ReadLine();
                person.Name = name;
                Console.Write("Age:");
                string age= Console.ReadLine();
                int ageNumber = int.Parse(age);
                person.Age = ageNumber;
                family.Persons.Add(person);
            }
            family.Print();

            Console.WriteLine("Task 3.......");
            Console.Write("Number of lines:");
            string linesCount = Console.ReadLine();
            int numberOfLines = int.Parse(linesCount);
            Statistic statistic = new Statistic();
            for (int i = 1; i <= numberOfLines; i++)
            {
                Person person = new Person();
                Console.WriteLine("Person {0}", i);
                Console.Write("Name:");
                string name = Console.ReadLine();
                person.Name = name;
                Console.Write("Age:");
                string age = Console.ReadLine();
                int ageNumber = int.Parse(age);
                person.Age = ageNumber;
                statistic.Persons.Add(person);
            }
            statistic.Print();
        }
    }
}
