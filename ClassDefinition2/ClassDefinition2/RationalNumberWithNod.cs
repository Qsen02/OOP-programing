using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDefinition2
{
    public class RationalNumberWithNod
    {
        private int Numerator;
        private int Denumerator;

        public RationalNumberWithNod(int numerator,int denumerator)
        {
            if (numerator > 0 && denumerator > 0)
            {
                int nod = this.BigestDivider(numerator, denumerator);
                this.Numerator = numerator / nod;
                this.Denumerator = denumerator / nod;
            }
        }
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
        public void Print(RationalNumberWithNod[] numbers)
        {
            List<string> rationalNumbers = new List<string>();
            foreach (RationalNumberWithNod number in numbers)
            {
                string rationalNumber = $"{number.Numerator}/{number.Denumerator}";
                rationalNumbers.Add(rationalNumber);
            }
            Console.WriteLine(string.Join("; ", rationalNumbers));
        }
        public int BigestDivider(int numerator, int denumerator)
        {
            while (denumerator != 0)
            {
                int temp = denumerator;
                denumerator = numerator % denumerator;
                numerator = temp;
            }
            return Math.Abs(numerator);
        }
    }
}
