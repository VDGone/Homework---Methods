using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LargerThanNeighbours
{
    public class LargerThanNeighbours
    {
        //Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
        public static bool GreaterThanNeighbours(int[] myArr, int index)
        {
            if (index <= 0 || index >= myArr.Length - 1)
            {
                return false;
            }
            else if (myArr[index] > myArr[index - 1] && myArr[index] > myArr[index + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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

            Console.WriteLine("Enter index of element that you want to check: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("The element on index{0} is larger than neighbours = {1}.", index, GreaterThanNeighbours(myArr, index));
        }
    }
}
