using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDefinition1
{
    public class Statistic
    {
        public List<Person> Persons { get; set; }

        public Statistic()
        {
            this.Persons = new List<Person>();
        }

        public void Print()
        {
            List<Person> sortedPersons = Persons.OrderBy(el => el.Name).ToList();
            foreach (Person person in sortedPersons)
            {
                if (person.Age > 30)
                {
                    Console.WriteLine("{0} - {1}", person.Name, person.Age);
                }
            }
        }
    }
}
