using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comapators.Task4
{
    public class NameComparer:IComparer<PersonPartial>
    {
        public int Compare(PersonPartial x, PersonPartial y) 
        {
            int result=x.Name.Length.CompareTo(y.Name.Length);
            if (result == 0) 
            {
                result = string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
            }
            return result;
        }
    }
}
