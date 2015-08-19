using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AddingPolynomials
{
    public class AddingPolynomias
    {
        //Write a method that adds two polynomials.
        //Represent them as arrays of their coefficients.

         public static void PrintPolynom(decimal[] polynom)
        {
            for (int i = polynom.Length - 1; i >= 0; i--)
            {
                if (polynom[i] != 0 && i != 0)
                {
                    if (polynom[i - 1] >= 0)
                    {
                        Console.Write("{1}x^{0} + ", i, polynom[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0}  ", i, polynom[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.Write("{0}", polynom[i]);
                }
            }
            Console.WriteLine();
        }
         public static decimal[] SumofPolynom(decimal[] firstPolyom, decimal[] secondPolynom, decimal[] result)
        {
            if (firstPolyom.Length > secondPolynom.Length)
            {
                return SumofPolynom(secondPolynom, firstPolyom, result);
            }

            for (int i = 0; i < firstPolyom.Length; i++)
            {
                result[i] = firstPolyom[i] + secondPolynom[i];
            }
            return result;
        }
        static void Main()
        {
            decimal[] firstPolynom = new decimal[4];

            Console.WriteLine("Enter values for first polynom: ");
            for (int i = 0; i < firstPolynom.Length; i++)
            {
                firstPolynom[i] = decimal.Parse(Console.ReadLine());
            }
            Array.Reverse(firstPolynom);

            decimal[] secondPolynom = new decimal[4];

            Console.WriteLine("Enter values for second polynom: ");
            for (int i = 0; i < secondPolynom.Length; i++)
            {
                secondPolynom[i] = decimal.Parse(Console.ReadLine());
            }
            Array.Reverse(secondPolynom);

            decimal[] result = new decimal[Math.Max(firstPolynom.Length, secondPolynom.Length)];

            Console.Write("First polynom: ");
            PrintPolynom(firstPolynom);
            Console.Write("Second polynom: ");
            PrintPolynom(secondPolynom);
            result = SumofPolynom(firstPolynom, secondPolynom, result);
            Console.Write("Sum: ");
            PrintPolynom(result);
        }
    }
}
