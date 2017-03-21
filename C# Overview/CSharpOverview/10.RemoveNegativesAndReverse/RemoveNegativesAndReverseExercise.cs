using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverseExercise
    {
        static void Main(string[] args)
        {
            int[] numbers = ReadNumbersFromConsole();
            List<int> nonNegativeNumbers = GetNonNegativeNumbers(numbers);

            if (nonNegativeNumbers.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            nonNegativeNumbers.Reverse();

            Console.WriteLine(string.Join(" ", nonNegativeNumbers));

        }

        private static int[] ReadNumbersFromConsole()
        {
            string input = 
                Console.ReadLine();
            string[] inputElements = 
                input.Split();

            int[] numbers = new int[inputElements.Length];

            for (int i = 0; i < inputElements.Length; ++i)
            {
                numbers[i] = int.Parse(inputElements[i]);
            }

            return numbers;
        }

        private static List<int> GetNonNegativeNumbers(int[] numbers)
        {
            List<int> nonNegativeNumbers = new List<int>();

            for (int i = 0; i < numbers.Length; ++i)
            {
                if (numbers[i] >= 0)
                    nonNegativeNumbers.Add(numbers[i]);
            }

            return nonNegativeNumbers;
        }
    }
}
