using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerCalculations
{
    //Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
    //Use variable number of arguments.

    class IntegerCalculations
    {
        static int Product(params int[] sequence)
        {
            int product = 1;

            for (int i = 0; i < sequence.Length; i++)
            {
                product *= sequence[i];
            }
            return product;
        }

        static int Sum(params int[] sequence)
        {
            int sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }
            return sum;
        }

        static double Average(params int[] sequence)
        {
            double sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }
            return sum / sequence.Length;
        }

        static int Max(params int[] sequence)
        {
            int max = int.MinValue;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] > max)
                {
                    max = sequence[i];
                }
            }
            return max;
        }

        static int Min(params int[] sequence)
        {
            int min = int.MaxValue;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] < min)
                {
                    min = sequence[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] myArr = new int[size];
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.Write("{0} element = ", i + 1);
                myArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Min: {0}", Min(myArr));
            Console.WriteLine("Max: {0}", Max(myArr));
            Console.WriteLine("Average: {0}", Average(myArr));
            Console.WriteLine("Sum: {0}", Sum(myArr));
            Console.WriteLine("Product: {0}", Product(myArr));
        }
    }
}
