using ObjectsAndEvents.Task1;

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
        static void Main(string[] args)
        {
            Task1();
        }
    }
}
