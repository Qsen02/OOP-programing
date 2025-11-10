using ObjectsAndEvents.Task1;
using ObjectsAndEvents.Task2;
using System.Timers;

namespace ObjectsAndEvents
{
    internal class Program
    {
        static void Task1() 
        {
            Console.WriteLine("Task 1......");
            Dispatcher dispatcher = new Dispatcher("Initial");
            Handler handler = new Handler();

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string command = "";
            while (command != "End") 
            {
                command = Console.ReadLine();
                dispatcher.SetName(command);
            }
        }
        static void Task2() 
        {
            Console.WriteLine("Task 2.....");
            string kingName = Console.ReadLine();
            King king = new King(kingName);
            List<RoyalGuard> guards = Console.ReadLine().Split(" ")
                .Select(el=> new RoyalGuard(el)).ToList();
            List<Footman> footmans = Console.ReadLine().Split(" ")
                .Select(el=> new Footman(el)).ToList();
            string command = "";
            while (true) 
            {
                command = Console.ReadLine();
                if (command == "End") 
                {
                    break;
                }
                if (command == "Attack King")
                {
                    king.KingAttacked();
                    foreach (RoyalGuard guard in guards)
                    {
                        guard.Action();
                    }
                    foreach (Footman footman in footmans)
                    {
                        footman.Action();
                    }
                } else if(command.Contains("Kill"))
                {
                    string[] commandLine = command.Split(" ");
                    bool isGuard = guards.Any(el => el.Name == commandLine[1]);
                    if (isGuard)
                    {
                        guards = guards.Where(el => el.Name != commandLine[1]).ToList();
                    }
                    else 
                    {
                        footmans = footmans.Where(el => el.Name != commandLine[1]).ToList();
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
    }
}
