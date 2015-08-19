using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11.AddingPolynomials;

namespace _12.SubtractingPolynomials
{
    class SubtractingPolynomials
    {
        //Extend the previous program to support also subtraction and multiplication of polynomials.
        static decimal[] substractionOfPolynoms(decimal[] firstPolyom, decimal[] secondPolynom, decimal[] result)
        {
            if (firstPolyom.Length > secondPolynom.Length)
            {
                return substractionOfPolynoms(secondPolynom, firstPolyom, result);
            }
            int i = 0;

            for (; i < firstPolyom.Length; i++)
            {
                result[i] = firstPolyom[i] - secondPolynom[i];
            }

            for (; i < secondPolynom.Length; i++)
            {
                result[i] = secondPolynom[i];
            }
            return result;
        }

        static decimal[] MultiplicationOfPolynoms(decimal[] firstPolynom, decimal[] secondPolynom, decimal[] result)
        {
            result = new decimal[firstPolynom.Length + secondPolynom.Length - 1];
            for (int i = firstPolynom.Length - 1; i >= 0; i--)
            {
                for (int j = secondPolynom.Length - 1; j >= 0; j--)
                {
                    result[i + j] += firstPolynom[i] * secondPolynom[j];
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many elements you want to use in polynoms");
            int n = int.Parse(Console.ReadLine());
            decimal[] firstPolynom = new decimal[n];

            Console.WriteLine("Enter values for first polynom: ");
            for (int i = 0; i < firstPolynom.Length; i++)
            {
                firstPolynom[i] = decimal.Parse(Console.ReadLine());
            }
            Array.Reverse(firstPolynom);

            decimal[] secondPolynom = new decimal[n];

            Console.WriteLine("Enter values for second polynom: ");
            for (int i = 0; i < secondPolynom.Length; i++)
            {
                secondPolynom[i] = decimal.Parse(Console.ReadLine());
            }
            Array.Reverse(secondPolynom);
     
            decimal[] result =new decimal [Math.Max(firstPolynom.Length, secondPolynom.Length)];

            Console.Write("First polynom: ");
            AddingPolynomias.PrintPolynom(firstPolynom);
            Console.Write("Second polynom: ");
            AddingPolynomias.PrintPolynom(secondPolynom);
            result =AddingPolynomias.SumofPolynom(firstPolynom, secondPolynom, result);
            Console.Write("Sum: ");
            AddingPolynomias.PrintPolynom(result);
            Console.Write("Subtraction: ");
            substractionOfPolynoms(firstPolynom, secondPolynom, result);
            AddingPolynomias.PrintPolynom(result);
            Console.Write("Multiplication: ");
            MultiplicationOfPolynoms(firstPolynom, secondPolynom, result);
            AddingPolynomias.PrintPolynom(result);
        }
    }
}
