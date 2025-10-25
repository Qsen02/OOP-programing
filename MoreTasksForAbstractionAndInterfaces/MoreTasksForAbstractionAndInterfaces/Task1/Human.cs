using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreTasksForAbstractionAndInterfaces.Task1
{
    public class Human:IId
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public Human(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
    }
}
