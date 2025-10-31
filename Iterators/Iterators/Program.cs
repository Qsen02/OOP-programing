using Iterators.Task1And2;
using Iterators.Task3And4;

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
                }
            }
        }
        static void Main(string[] args)
        {
            Task1And2();
            Task3And4();
        }
    }
}
