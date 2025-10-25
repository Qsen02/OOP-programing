using MoreTasksForAbstractionAndInterfaces.Task1;
using MoreTasksForAbstractionAndInterfaces.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreTasksForAbstractionAndInterfaces.Task3
{
    public class Citizen:IId,IBirthday,IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
        public int Food { get; set; }
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
            Food = 0;
        }
        public void BuyFood() 
        {
            Food += 10;
        }
    }
}
