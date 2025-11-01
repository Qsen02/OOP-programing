using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comapators.Task4
{
    public class AgeComparer: IComparer<PersonPartial>
    {
        public int Compare(PersonPartial x, PersonPartial y) 
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
