namespace FunctionalProgrammingExercises
{
    internal class Program
    {
        static void Task1() 
        {
            Action<string[]> printElements = (collection) =>
            {
                foreach (string element in collection)
                {
                    Console.WriteLine(element);
                }
            };
            Console.WriteLine("Task 1.....");
            string[] words = Console.ReadLine().Split(" ");
            printElements(words);
        }
        static void Task2()
        {
            Console.WriteLine("Task 2......");
            Action<string[]> printElements = (collection) =>
            {
                foreach (string element in collection)
                {
                    Console.WriteLine($"Sir {element}");
                }
            };
            string[] words = Console.ReadLine().Split(" ");
            printElements(words);
        }
        static void Task3() 
        {
            Func<int[], int> min = (numbers) =>
            {
                int smallestNumber = Int32.MaxValue;
                foreach (int number in numbers)
                {
                    if (smallestNumber > number)
                    {
                        smallestNumber = number;
                    }
                }
                return smallestNumber;
            };
            Console.WriteLine("Task 3......");
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Console.WriteLine(min(numbers));
        }
        static void Task4()
        {
            Console.WriteLine("Task 4......");
            Func<int, int, string, List<int>> filterNumbers = (min, max, command) =>
            {
                List<int> numbers = new List<int>();
                switch (command)
                {
                    case "odd":
                        for (int i = min; i < max; i++)
                        {
                            if (i % 2 != 0)
                            {
                                numbers.Add(i);
                            }
                        }
                        break;
                    case "even":
                        for (int i = min; i < max; i++)
                        {
                            if (i % 2 == 0)
                            {
                                numbers.Add(i);
                            }
                        }
                        break;
                }
               return numbers;
            };
            int[] interval = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            List<int> numbers = filterNumbers(interval[0], interval[1], command);
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void Task5() 
        {
            Func<int, int> add = (number) =>
            {
                return number + 1;
            };
            Func<int, int> multiply = (number) =>
            {
                return number * 2;
            };
            Func<int, int> substract = (number) =>
            {
                return number - 1;
            };
            Action<List<int>> print = (numbers) =>
            {
                Console.WriteLine(string.Join(" ", numbers));
            };
            Console.WriteLine("Task 5.......");
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = "";
            while (command != "end") 
            {
                command = Console.ReadLine();
                switch (command) 
                {
                    case "add":
                        numbers = numbers.Select(add).ToList(); 
                        break;
                    case "multiply":
                        numbers = numbers.Select(multiply).ToList();
                        break;
                    case "substract":
                        numbers = numbers.Select(substract).ToList();
                        break;
                    case "print":
                        print(numbers);
                        break;
                }
            }
        }
        static void Task6() 
        {
            Func<int[], List<int>> reverse = (numbers) =>
            {
                List<int> result = new List<int>();
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    result.Add(numbers[i]);
                }
                return result;
            };
            Console.WriteLine("Task 6......");
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            Predicate<int> isDeleted = (a) => a % n == 0;
            List<int> reversedNumbers = reverse(numbers);
            reversedNumbers = reversedNumbers.Where(el => !isDeleted(el)).ToList();
            Console.WriteLine(string.Join(" ",reversedNumbers));
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            Task6();
        }
    }
}
