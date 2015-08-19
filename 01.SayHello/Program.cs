using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SayHello
{
    //Write a method that asks the user for his name and prints “Hello, <name>”
    //Write a program to test this method.
    static void AskUserForName()
    {
        Console.WriteLine("What is your first name ?");
    }
    static void CheckStringAndPrint(string firstName)
    {
        bool isCorrect = firstName.All(Char.IsLetter);
        if (isCorrect && firstName.Length > 2)
        {
            Console.WriteLine("Hello, {0}!", firstName);
        }
        else
        {
            Console.WriteLine("Are you kidding me?");
        }
    }
    static void Main(string[] args)
    {
        AskUserForName();
        string firstName = Console.ReadLine();
        CheckStringAndPrint(firstName);
    }
}

