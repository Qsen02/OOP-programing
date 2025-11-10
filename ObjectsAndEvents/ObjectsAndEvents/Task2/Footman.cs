using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndEvents.Task2
{
    public class Footman
    {
        public string Name { get; set; }
        public Footman(string Name)
        {
            this.Name = Name;
        }
        public void Action() 
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
