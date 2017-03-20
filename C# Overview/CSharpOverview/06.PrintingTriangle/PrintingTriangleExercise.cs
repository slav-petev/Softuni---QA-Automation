using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrintingTriangle
{
    class PrintingTriangleExercise
    {
        static void Main(string[] args)
        {
            int maxNumberToPrint = int.Parse(
                Console.ReadLine());

            for (int i = 1; i < maxNumberToPrint; ++i)
            {
                PrintLine(1, i);
            }

            PrintLine(1, maxNumberToPrint);

            for (int i = maxNumberToPrint - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        private static void PrintLine(int startNumber, int endNumber)
        {
            for (int i = startNumber; i <= endNumber; ++i)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
