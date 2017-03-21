using System;
using System.Collections.Generic;

namespace _11.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbersExercise
    {
        static void Main(string[] args)
        {
            double[] numbers = ReadNumbers();

            if (!HasAdjacentEqualElements(numbers))
            {
                PrintNumbers(numbers);
                return;
            }

            double[] result = SumAllAdjacentEqualElements(numbers);

            PrintNumbers(result);
        }

        private static double[] ReadNumbers()
        {
            string input = 
                Console.ReadLine();
            string[] inputElements = 
                input.Split();

            double[] numbers = new double[inputElements.Length];

            for (int i = 0; i < inputElements.Length; ++i)
            {
                numbers[i] = double.Parse(inputElements[i]);
            }

            return numbers;
        }

        private static bool HasAdjacentEqualElements(double[] array)
        {
            for (int i = 0; i < array.Length - 1; ++i)
            {
                if (array[i] == array[i + 1])
                    return true;
            }

            return false;
        }

        private static double[] SumAllAdjacentEqualElements(double[] array)
        {
            double[] result = SumAdjacentEqualElements(array);
            while (HasAdjacentEqualElements(result))
            {
                result = SumAdjacentEqualElements(result);
            }

            return result;
        }

        private static double[] SumAdjacentEqualElements(double[] array)
        {
            List<double> result = new List<double>();

            for (int i = 0; i < array.Length - 1; ++i)
            {
                if (array[i] == array[i + 1])
                {
                    double sum = 2 * array[i];
                    result.Add(sum);
                    AddElementsFromTo(array, i + 2, result);
                    break;
                }

                result.Add(array[i]);
            }

            return result.ToArray();
        }

        private static void AddElementsFromTo(double[] source, int sourceStartIndex, 
            List<double> destination)
        {
            for (int i = sourceStartIndex; i < source.Length;++i)
            {
                destination.Add(source[i]);
            }
        }

        private static void PrintNumbers(IEnumerable<double> numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
