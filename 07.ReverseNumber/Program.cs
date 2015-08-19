using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseNumber
{
    class ReverseNumber
    {
        //Write a method that reverses the digits of given decimal number.
        static double ReversedNumbers(double n)
        {
            return double.Parse(new string(n.ToString().ToCharArray().Reverse().ToArray()));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Your number: {0}, reverse number: {1}.", n, ReversedNumbers(n));
        }
    }
}
