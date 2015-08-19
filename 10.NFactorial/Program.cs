using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.NFactorial
{
    //Write a program to calculate n! for each n in the range [1..100].
    //Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
    class NFactorial
    {
        static BigInteger FactorialOfNumber(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static void MultipliesNumber(int[] myArr)
        {
            for (int i = 1; i < myArr.Length; i++)
            {
                BigInteger factorial = FactorialOfNumber(i);
                Console.WriteLine("Factorial of {0} = {1}.\n", i, factorial);
            }
        }
        static void Main(string[] args)
        {
            int[] myArr = new int[101];
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = i;
            }
            MultipliesNumber(myArr);
        }
    }
}
