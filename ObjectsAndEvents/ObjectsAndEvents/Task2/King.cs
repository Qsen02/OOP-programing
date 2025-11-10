using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndEvents.Task2
{
    public delegate void KingAppeared(object sender, NameEventArgs args);
    public class King
    {
        public string Name { get; set; }
        public King(string Name) 
        {
            this.Name = Name;
        }
        public void KingAttacked() 
        {
            Console.WriteLine($"King {this.Name} is under attack!");
        }
    }
}
