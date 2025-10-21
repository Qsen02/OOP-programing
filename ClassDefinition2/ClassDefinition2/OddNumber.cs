using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDefinition2
{
    public class OddNumber
    {
        private int number;

        public int GetNumber()
        {
            return this.number;
        }
        public void SetNumber(int num)
        {
            this.number = num;
        }

        public void PrintOddNumbers(int[] numbers)
        {
            int[] oddNumbers = numbers.Where(el => el % 2 != 0).ToArray();
            Console.WriteLine(string.Join(", ", oddNumbers));
        }
    }
}
