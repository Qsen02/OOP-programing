using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ClassDefinition2
{
    public class EvenNumber
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

        public void PrintEvenNumbers(int[] numbers)  
        {
            int[] evenNumbers = numbers.Where(el => el % 2 == 0).ToArray();
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
