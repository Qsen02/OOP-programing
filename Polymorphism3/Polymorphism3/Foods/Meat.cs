using Polymorphism3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism3.Foods
{
    public class Meat: Food
    {
        public Meat(int quantity) 
        {
            Quantity = quantity;
        }
    }
}
