using System;

namespace _01_Calculator
{
    internal class Calculator
    {
        internal static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        internal static int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        internal static int Sum(int[] numbers)
        {
            int sum = 0;
            /*for(int i = 0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }*/
            foreach(int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        internal static int Multiply(int[] numbers)
        {
            int mult = 1;
            /*for(int i = 0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }*/
            if (numbers.Length <= 0)
                return 0;

            foreach (int number in numbers)
            {
                mult *= number;
            }
            return mult;
        }

        internal static int Power(int v1, int v2)
        {
            return (int) Math.Pow(v1,v2);
        }

        internal static int Factorial(int v)
        {
            int factSum = 1;
            for(int i = v; i>0; i--)
            {
                factSum *= i;
            }
            return factSum;
        }
    }
}