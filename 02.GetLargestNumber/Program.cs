using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GetLargestNumber
{
    //Write a method GetMax() with two parameters that returns the larger of two integers.
    //Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

    static int GetMax(int a, int b)
    {
        int greater = Math.Max(a, b);
        return greater;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for c: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is:" + GetMax(GetMax(a, b),c));
        
    }
}

