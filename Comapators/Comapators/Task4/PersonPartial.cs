using Comapators.Task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comapators.Task4
{
    public class PersonPartial
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public PersonPartial(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override bool Equals(object obj)
        {
            if (obj is not Person other) return false;

            return string.Equals(Name, other.Name)
                   && Age == other.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name?.ToLower(), Age);
        }

    }
}
