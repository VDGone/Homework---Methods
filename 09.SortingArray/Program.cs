using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SortingArray
{
    class SortingArray
    {
        //Write a method that return the maximal element in a portion of array of integers starting at given index.
        //Using it write another method that sorts an array in ascending / descending order.
        static void Main()
        {
            Console.WriteLine("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter index of array between 0 and {0}", size - 1);
            int userIndex = int.Parse(Console.ReadLine());

            int[] myArray = new int[size];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Array[{0}] = ", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Maximal element in a portion of array starting form given index {0}  = {1}\n", userIndex, MaximalElement(userIndex, myArray));
            Console.Write("Ascending order: ");
            Console.WriteLine(string.Join(" ", AscendingArray(myArray)));
            Console.Write("Descending order: ");
            Console.WriteLine(string.Join(" ", DescendingArray(myArray)));

        }
        static int MaximalElement(int indexInArray, int[] array)
        {
            int maxElement = 0;

            for (int i = indexInArray; i < array.Length; i++)
            {
                if (maxElement < array[i])
                {
                    maxElement = array[i];
                }
            }
            return maxElement;
        }

        static int[] DescendingArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int indexMax = Array.IndexOf(array, MaximalElement(i, array), i);
                int temp = array[indexMax];
                array[indexMax] = array[i];
                array[i] = temp;
            }
            return array;
        }
        static int[] AscendingArray(int[] array)
        {
            Array.Reverse(DescendingArray(array));
            return array;
        }
    }
}
