using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AppearanceCount
{
    //Write a method that counts how many times given number appears in given array.
    //Write a test program to check if the method is workings correctly.
    static int NumberAppearance(int[] myArr, int givenNumber)
    {
        int count = 0;
        foreach (var number in myArr)
        {
            if (givenNumber == number)
            {
                count++;
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of array: ");
        int size = int.Parse(Console.ReadLine());
        int[] myArr = new int[size];
        Console.WriteLine("Enter number for check: ");
        int givenNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.Write("Array[{0}] = ", i);
            myArr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Number {0} is founnd {1} times.", givenNumber, NumberAppearance(myArr, givenNumber));
    }
}

