using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firgures
{
    public abstract class Figure
    {
       public abstract double calculatePerimeter();
       public abstract double calculateArea();
       public virtual string Draw()
       {
            return "Figure!";
       }
    }
}
