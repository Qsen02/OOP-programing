using MoreTasksForAbstractionAndInterfaces.Task1;
using MoreTasksForAbstractionAndInterfaces.Task2;
using System.Collections;

namespace MoreTasksForAbstractionAndInterfaces
{
    internal class Program
    {
        static void Task1() 
        {
            Console.WriteLine("Task 1.....");
            string command = "";
            List<IId> subjects= new List<IId>();
            while (command != "End") 
            {
                command=Console.ReadLine();
                if (command != "End") 
                {
                    string[] commandLine = command.Split(" ");
                    if (commandLine.Length == 2)
                    {
                        Robot robot = new Robot(commandLine[0], commandLine[1]);
                        subjects.Add(robot);
                    }
                    else 
                    {
                        Human human = new Human(commandLine[0], int.Parse(commandLine[1]), commandLine[2]);
                        subjects.Add(human);
                    }
                }
            }
            string limitter=Console.ReadLine();
            foreach (var subject in subjects) 
            {
                if (subject.Id.EndsWith(limitter)) 
                {
                    Console.WriteLine(subject.Id);
                }
            }
        }
        static void Task2()
        {
            Console.WriteLine("Task 2.....");
            string command = "";
            List<IBirthday> subjects = new List<IBirthday>();
            while (command != "End")
            {
                command = Console.ReadLine();
                if (command != "End")
                {
                    string[] commandLine = command.Split(" ");
                    switch (commandLine[0]) 
                    {
                        case "Citizen":
                            string name = commandLine[1];
                            int age=int.Parse(commandLine[2]);
                            string id=commandLine[3];
                            string birthdate = commandLine[4];
                            Human1 human = new Human1(name,age,id,birthdate);
                            subjects.Add(human);
                        break;
                        case "Pet":
                            string petName = commandLine[1];
                            string petBirthdate = commandLine[2];
                            Pet pet = new Pet(petName, petBirthdate);
                            subjects.Add(pet);
                        break;
                    }
                }
            }
            string limitter = Console.ReadLine();
            foreach (var subject in subjects)
            {
                string[] birthDateArr=subject.Birthdate.Split("/");
                if (birthDateArr[2] == limitter) 
                {
                    Console.WriteLine(subject.Birthdate);
                }
            }
            if (subjects.Count == 0) 
            {
                Console.WriteLine("<empty output>");
            }
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
    }
}
