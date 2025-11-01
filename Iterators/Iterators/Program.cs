using Iterators.Task1And2;
using Iterators.Task3And4;
using Iterators.Task5;
using Iterators.Task6;

namespace Iterators
{
    internal class Program
    {
        static void Task1And2() 
        {
            Console.WriteLine("Task 1 and 2......");
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);
            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book.Title);
            }
        }
        static void Task3And4() 
        {
            Console.WriteLine("Task 3 and 4.....");
            List<string> elements=Console.ReadLine().Split(" ").ToList();
            elements.RemoveAt(0);
            ListIterator<string> listElements = new ListIterator<string>(elements);
            string command = "";
            List<string> commands= new List<string>();
            while (command != "END") 
            {
                command = Console.ReadLine();
                commands.Add(command);
            }
            foreach (string curCommand in commands) 
            {
                switch (curCommand)
                {
                    case "Move":
                        Console.WriteLine(listElements.Move());
                        break;
                    case "Print":
                        listElements.Print();
                        break;
                    case "HasNext":
                        Console.WriteLine(listElements.HasNext());
                        break;
                    case "PrintAll":
                        string result = "";
                        foreach (string element in listElements) 
                        {
                            result += element + " ";
                        }
                        Console.WriteLine(result);
                        break;
                }
            }
        }
        static void Task5() 
        {
            Console.WriteLine("Task 5.....");
            string command = "";
            CustomStack<string> stack= new CustomStack<string>();
            while (command != "END") 
            {
                command = Console.ReadLine();
                string[] commandLine = command.Split(" ");
                switch (commandLine[0]) 
                {
                    case "Push":
                        List<string> elements = command.Split(" ").ToList();
                        elements.RemoveAt(0);
                        foreach (string element in elements) 
                        {
                            stack.Push(element);
                        }
                    break;
                    case "Pop":
                        stack.Pop();
                    break;
                }
            }
            foreach (string element in stack) 
            {
                Console.WriteLine(element);
            }
            foreach (string element in stack)
            {
                Console.WriteLine(element);
            }
        }
        static void Task6() 
        {
            Console.WriteLine("Task 6.....");
            List<int> stones = Console.ReadLine().Split(", ").Select(el => int.Parse(el)).ToList();
            Lake lake = new Lake(stones);
            List<int> result=new List<int>();
            List<int> odds=new List<int>();
            List<int> evens=new List<int>();
            foreach (int stone in stones)
            {
                if (stone % 2 == 0)
                {
                    evens.Add(stone);
                }
                else {
                    odds.Add(stone);
                }
            }
            odds.Sort();
            evens.Reverse();
            result = [..odds, ..evens];
            Console.WriteLine(string.Join(", ",result));
        }
        static void Main(string[] args)
        {
            Task1And2();
            Task3And4();
            Task5();
            Task6();
        }
    }
}
