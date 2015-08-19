using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SolveTasks
{
    //Write a program that can solve these tasks:
    //Reverses the digits of a number
    //Calculates the average of a sequence of integers
    //Solves a linear equation a * x + b = 0
    //Create appropriate methods.
    //Provide a simple text-based menu for the user to choose which task to solve.
    //Validate the input data:
    //The decimal number should be non-negative
    //The sequence should not be empty
    //a should not be equal to 0
    class SolveTasks
    {
        static void EquationInput()
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("a must not be equal to Zero!");
            }
            else
            {
                Console.WriteLine("Equation result is {0}", CalculateEquation(a, b));
            }
        }

        static double CalculateEquation(int a, int b)
        {
            return (double)-b / a;
        }

        static void AverageOfSequence()
        {
            Console.Write("Enter size of sequence: ");
            int size = int.Parse(Console.ReadLine());

            if (size <= 0)
            {
                Console.WriteLine("The sequence must have at least 1 element!");
                return;
            }

            int[] sequence = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("sequence[{0}] = ", i + 1);
                sequence[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The average sequence is: {0}", CalculateAverage(sequence));
        }

        static double CalculateAverage(int[] sequence)
        {
            int sum = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }

            return (double)sum / sequence.Length;
        }

        static void ReverseNumber()
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();

            if (decimal.Parse(number) > 0)
            {
                Console.WriteLine("The reversed number is " + Reverse(number));
            }
            else
            {
                Console.WriteLine("The number must be positive!");
            }
        }

        static decimal Reverse(string number)
        {
            char[] toBeReversed = number.ToCharArray();
            Array.Reverse(toBeReversed);
            string reversed = new string(toBeReversed);

            decimal reversedNumber = decimal.Parse(reversed);

            return reversedNumber;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Chose what to do: ");
            Console.WriteLine("Press:\n1.Reverse number\n2.Calculates the average of a sequence of integers\n3.Solves a linear equation a * x + b = 0 ");

            Console.WriteLine("Your choice: ");
            int number = int.Parse(Console.ReadLine());

            do
            {
                switch (number)
                {
                    case 1:
                        ReverseNumber();
                        break;
                    case 2:
                        AverageOfSequence();
                        break;
                    case 3:
                        EquationInput();
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            } 
            while (number > 0 || number <= 3);
        }
    }
}
