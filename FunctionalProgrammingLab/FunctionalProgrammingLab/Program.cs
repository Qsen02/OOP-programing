using System.Linq;
using System.Timers;

namespace FunctionalProgrammingLab
{
    internal class Program
    {
        static void Task1() 
        {
            Console.WriteLine("Task 1.....");
            List<int> numbers=Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            List<int> filteredNumbers = numbers.Where(el => el % 2 == 0).Order().ToList();
            Console.WriteLine(string.Join(", ", filteredNumbers));
        }
        static void Task2() 
        {
            Console.WriteLine("Task 2.....");
            List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Sum());
        }
        static void Task3()
        {
            Console.WriteLine("Task 3......");
            string[] words=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];
            words.Where(checker).ToList().ForEach(n => Console.WriteLine(n));

        }
        static void Task4() 
        {
            Console.WriteLine("Task 4.....");
            Console.ReadLine().Split(", ")
                .Select(double.Parse)
                .Select(el => el * 1.2)
                .ToList()
                .ForEach(el => Console.WriteLine($"{el:F2}"));
        }
        static void Task5() 
        {
            Func<string, int, List<string>, List<string>> check = (state, age, peoples) =>
            {
                List<string> result = new List<string>();
                foreach (string people in peoples)
                {
                    string[] command = people.Split(", ");
                    string name = command[0];
                    int curAge = int.Parse(command[1]);
                    if (state == "older")
                    {
                        if (curAge >= age)
                        {
                            result.Add(people);
                        }
                    }
                    else if (state == "younger")
                    {
                        if (curAge < age)
                        {
                            result.Add(people);
                        }
                    }
                }
                return result;
            };
            Console.WriteLine("Task 5.....");
            int lines = int.Parse(Console.ReadLine());
            List<string> peoples = new List<string>();
            for (int i = 0; i < lines; i++) 
            {
                peoples.Add(Console.ReadLine());
            }
            string state= Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            List<string> filteredPeoples = check(state,age,peoples);
            if (format == "name")
            {
                foreach (string people in filteredPeoples)
                {
                    Console.WriteLine(people.Split(", ")[0]);
                }
            }
            else if (format == "age")
            {
                foreach (string people in filteredPeoples)
                {
                    Console.WriteLine(people.Split(", ")[1]);
                }
            }
            else 
            {
                foreach (string people in filteredPeoples)
                {
                    string[] command = people.Split(", ");
                    Console.WriteLine($"{command[0]} - {command[1]}");
                }
            }
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }
    }
}
