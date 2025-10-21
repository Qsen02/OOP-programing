using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDefinition2
{
    public class RationalNumber
    {
        private int Numerator;
        private int Denumerator;
        public void SetNumerator(int num) 
        {
                this.Numerator = num;
        }
        public int GetNumerator() 
        {
            return this.Numerator;
        }
        public int GetDenumerator()
        {
            return this.Denumerator;
        }
        public void SetDenumerator(int num)
        {
            if (num > 0)
            {
                this.Denumerator = num;
            }
            else
            {
                Console.WriteLine("Denumerator must be greater than 0!");
                return;
            }
        }
        public void Print(RationalNumber[] numbers)
        {
           List<string> rationalNumbers = new List<string>();
            foreach (RationalNumber number in numbers)
            {
                string rationalNumber = $"{number.Numerator}/{number.Denumerator}";
                rationalNumbers.Add(rationalNumber);
            }
            Console.WriteLine(string.Join("; ", rationalNumbers));
        }
    }
}
