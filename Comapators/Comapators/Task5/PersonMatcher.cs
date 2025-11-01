using Comapators.Task3;
using Comapators.Task4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Comapators.Task5
{
    public class PersonMatcher: IComparer<PersonPartial>
    {
        public int Compare(PersonPartial x, PersonPartial y) 
        {
            int result = x.Name.CompareTo(y.Name);
            if (result == 0) 
            {
                result = x.Age.CompareTo(y.Age);
            }
            return result;
        }

    }
}
