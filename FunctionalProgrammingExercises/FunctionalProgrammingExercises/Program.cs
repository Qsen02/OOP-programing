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
        static void Task7() 
        {
            Action<string[], int> printNames = (names, length) =>
            {
                foreach (string name in names)
                {
                    if (name.Length <= length)
                    {
                        Console.WriteLine(name);
                    }
                }
            };
            Console.WriteLine("Task 7......");
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ");
            printNames(names, length);
        }
        static void Task8() 
        {
            Func<int, int, int> compare = (num1, num2) =>
            {
                bool num1IsEven = num1 % 2 == 0;
                bool num2IsEven = num2 % 2 == 0;
                if (num1IsEven && !num2IsEven)
                {
                    return 1;
                }
                else if (!num1IsEven && num2IsEven)
                {
                    return -1;
                }
                return 0;
            };
            Console.WriteLine("Task 8......");
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Array.Sort(numbers,(a,b) => compare(a,b));
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void Task9()
        {
            Func<List<int>, int, List<int>> filter = (numbers, interval) =>
            {
                List<int> result = new List<int>();
                for (int i = 1; i <= interval; i++)
                {
                    bool isDeleted = true;
                    foreach (int number in numbers) 
                    {
                        if (i % number != 0) 
                        {
                            isDeleted = false;
                        }
                    }
                    if (isDeleted)
                    {
                        result.Add(i);
                    }
                }
                return result;
            };
            Console.WriteLine("Task 9......");
            int interval=int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> filteredNumbers = filter(numbers, interval);
            Console.WriteLine(string.Join(" ",filteredNumbers));
        }
        static void Task10() 
        {
            Func<List<string>, string, string, List<string>> startsWith = (guests, command, value) =>
            {
                if (command == "Remove")
                {
                    return guests.Where(el => !el.StartsWith(value)).ToList();
                }
                List<string> matches = guests.Where(el => el.StartsWith(value)).ToList();
                return [.. guests, .. matches];
            };
            Func<List<string>, string, string, List<string>> endsWith = (guests, command, value) =>
            {
                if (command == "Remove")
                {
                    return guests.Where(el => !el.EndsWith(value)).ToList();
                }
                List<string> matches = guests.Where(el => el.EndsWith(value)).ToList();
                return [.. guests, .. matches];
            };
            Func<List<string>, string, int, List<string>> mathingLength = (guests, command, value) =>
            {
                if (command == "Remove")
                {
                    return guests.Where(el => !(el.Length == value)).ToList();
                }
                List<string> matches = guests.Where(el => el.Length == value).ToList();
                return [.. guests, .. matches];
            };
            Console.WriteLine("Task 10.......");
            List<string> guests = Console.ReadLine().Split(" ").ToList();
            string command = "";
            while (command != "Party!") 
            {
                command = Console.ReadLine();
                if (command == "Party!") 
                {
                    break;
                }
                string[] commandLine = command.Split(" ");
                switch (commandLine[1]) 
                {
                    case "StartsWith":
                        guests = startsWith(guests, commandLine[0], commandLine[2]);
                        break;
                    case "EndsWith":
                        guests = endsWith(guests, commandLine[0], commandLine[2]);
                        break;
                    case "Length":
                        guests = mathingLength(guests, commandLine[0], int.Parse(commandLine[2]));
                        break;
                }
            }
            if (guests.Count == 0)
            {
                Console.WriteLine("Nobody in going to the party!");
            }
            else 
            {
                Console.WriteLine(string.Join(", ", guests) + " are going to the party!");
            }
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
            Task9();
            Task10();
        }
    }
}
