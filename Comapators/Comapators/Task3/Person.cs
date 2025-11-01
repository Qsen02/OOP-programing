using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comapators.Task3
{
    public class Person: IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }
        public int CompareTo(Person other) 
        {
            int result= Name.CompareTo(other.Name);
            if (result == 0) 
            {
                result = Age.CompareTo(other.Age);
                if (result == 0) 
                {
                    result = City.CompareTo(other.City);
                }
            }
            return result;
        }
    }
}
