using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.LargerThanNeighbours;

namespace _06.FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbour
    {
        //Write a method that returns the index of the first element in array that is larger than its neighbours, 
        //or -1, if there’s no such element.
        //Use the method from the previous exercise.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] myArr = new int[size];

            for (int i = 0; i < myArr.Length; i++)
            {
                Console.Write("Array[{0}] = ", i);
                myArr[i] = int.Parse(Console.ReadLine());
            }
            int index = -1;

            for (int i = 0; i < myArr.Length; i++)
            {
                if (LargerThanNeighbours.GreaterThanNeighbours(myArr, i))
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                Console.WriteLine(index); 
            }
            else
            {
                Console.WriteLine("The first index of element larger than his neighbours is {0}", index);
            }
        }
    }
}
