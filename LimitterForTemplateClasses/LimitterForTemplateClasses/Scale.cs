using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitterForTemplateClasses
{
    public class Scale<T>
    {
        public T Left { get; set; }
        public T Right { get; set; }

        public Scale(T left, T right)
        {
            Left = left;
            Right = right;
        }

        public T GetHeavier() 
        {
            if ((dynamic)Left > (dynamic)Right)
            {
                return Left;
            }
            else if ((dynamic)Left == (dynamic)Right)
            {
                return default(T);
            }
            else 
            {
                return Right;
            }
        }
    }
}
