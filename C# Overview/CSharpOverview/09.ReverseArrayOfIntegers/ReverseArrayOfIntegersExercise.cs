using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegersExercise
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(
                Console.ReadLine());
            int[] array = ReadIntegerArray(arrayLength);
            ReverseIntegerArray(array);

            Console.WriteLine(string.Join(" ", array));
        }

        private static int[] ReadIntegerArray(int arrayLength)
        {
            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; ++i)
            {
                int number = int.Parse(
                    Console.ReadLine());
                array[i] = number;
            }

            return array;
        }

        private static void ReverseIntegerArray(int[] array)
        {
            int middle = array.Length / 2;

            for (int i = 0; i < middle; i++)
            {
                SwapArrayElements(array, i, array.Length - i - 1);
            }
        }

        private static void SwapArrayElements(int[] array, int firstElementPosition, 
            int secondElementPosition)
        {
            int firstElement = array[firstElementPosition];
            int secondElement = array[secondElementPosition];

            array[firstElementPosition] = secondElement;
            array[secondElementPosition] = firstElement;
        }
    }
}
