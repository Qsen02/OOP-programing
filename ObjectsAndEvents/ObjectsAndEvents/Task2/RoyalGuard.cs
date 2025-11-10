using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndEvents.Task2
{
    public class RoyalGuard
    {
        public string Name { get; set; }
        public RoyalGuard(string Name)
        {
            this.Name = Name;
        }
        public void Action() 
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
