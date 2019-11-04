using System;
namespace Miniräknare
{
    public class Calculator
    {

        internal int FirstNumber;
        internal int SecondNumber;
        internal int NumberInMemory;

        public Calculator()
        {
            this.FirstNumber = 0;
            this.SecondNumber = 0;
            this.NumberInMemory = 0;
        }

        public override string ToString()
        {
            return ($"FirstNumber: {FirstNumber} SecondNumber: {SecondNumber} NumberInMemory: {NumberInMemory}");
        }

        public int SumNumbers()
        { 
            return FirstNumber + SecondNumber;
        }

        public int MultiplyNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public int SumInBetween()
        {
            var sum = 0;
            for (int i = FirstNumber; i <= SecondNumber; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
