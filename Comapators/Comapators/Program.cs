using Comapators.Task3;
using Comapators.Task4;
using Comapators.Task5;
using Iterators.Task1And2;

namespace Comapators
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

            foreach (Book book in libraryTwo)
            {
                Console.WriteLine(book.ToString());
            }
        }
        static void Task3()
        {
            Console.WriteLine("Task 3.....");
            string command = "";
            List<Person> persons= new List<Person>();
            while (true) 
            {
                command = Console.ReadLine();
                if (command == "END") 
                {
                    break;
                }
                string[] commandLine = command.Split(" ");
                Person person = new Person(commandLine[0], int.Parse(commandLine[1]), commandLine[2]);
                persons.Add(person);
            }
            int matchingIndex = int.Parse(Console.ReadLine());
            int matchingPersons = 0;
            int notMathcingPersons = 0;
            for (int i = 0; i < persons.Count; i++) 
            {
                int isMatched = persons[matchingIndex - 1].CompareTo(persons[i]);
                if (isMatched == 0)
                {
                    matchingPersons++;
                }
                else 
                {
                    notMathcingPersons++;
                }
            }
            if (matchingPersons <= 1)
            {
                Console.WriteLine("No matches");
            }
            else 
            {
                Console.WriteLine($"{matchingPersons} {notMathcingPersons} {persons.Count}");
            }
        }
        static void Task4() 
        {
            Console.WriteLine("Task 4.....");
            int lines=int.Parse(Console.ReadLine());
            NameComparer nameComparer = new NameComparer();
            AgeComparer ageComparer = new AgeComparer();
            SortedSet<PersonPartial> personsByName = new SortedSet<PersonPartial>(nameComparer);
            SortedSet<PersonPartial> personsByAge = new SortedSet<PersonPartial>(ageComparer);
            List<PersonPartial> persons = new List<PersonPartial>();
            for (int i = 0; i < lines; i++) 
            {
                string[] commandLine = Console.ReadLine().Split(" ");
                PersonPartial person = new PersonPartial(commandLine[0], int.Parse(commandLine[1]));
                personsByName.Add(person);
                personsByAge.Add(person);
            }
            foreach (PersonPartial person in personsByName) 
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
            foreach (PersonPartial person in personsByAge)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
        static void Task5() 
        {
            Console.WriteLine("Task 5......");
            int lines = int.Parse(Console.ReadLine());
            PersonMatcher personMatcher = new PersonMatcher();
            SortedSet<PersonPartial> personSet = new SortedSet<PersonPartial>(personMatcher);
            HashSet<PersonPartial> personHash = new HashSet<PersonPartial>();
            for (int i = 0; i < lines; i++) 
            {
                string[] commandLine = Console.ReadLine().Split(" ");
                PersonPartial person = new PersonPartial(commandLine[0], int.Parse(commandLine[1]));
                personSet.Add(person);
                personHash.Add(person);
            }
            Console.WriteLine(personSet.Count);
            Console.WriteLine(personHash.Count);
        }
        static void Main(string[] args)
        {
            Task1And2();
            Task3();
            Task4();
            Task5();
        }
    }
}
