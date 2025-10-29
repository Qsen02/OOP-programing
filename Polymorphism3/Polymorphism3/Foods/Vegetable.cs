using Polymorphism3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism3.Foods
{
    public class Vegetable : Food
    {
        public Vegetable(int quantity) 
        {
            Quantity = quantity;
        }
    }
}
