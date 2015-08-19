using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EnglishDigit
{
    //Write a method that returns the last digit of given integer as an English word.
    static int LastDigit(int number)
    {
        int lastDigit = number % 10;
        return lastDigit;
    }
    static void DigitToWord(int digit) 
    {
        switch (digit)
        {
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("seven");
                break;
            case 8:
                Console.WriteLine("eight");
                break;
            case 9:
                Console.WriteLine("nine");
                break;
            case 0:
                Console.WriteLine("zero");
                break;
            default:
                Console.WriteLine("Its not a number");
                break;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int digit = LastDigit(number);

        Console.Write("Digit to word: {0} - ", digit);
        DigitToWord(digit);
    }
}

