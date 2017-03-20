using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SignOfIntegerNumber
{
    class SIgnOfIntegerNumberExercise
    {
        static void Main(string[] args)
        {
            int number = int.Parse(
                Console.ReadLine());

            string numberSign = GetNumberSign(number);

            Console.WriteLine("The number {0} is {1}.",
                number, numberSign);
        }

        private static string GetNumberSign(int number)
        {
            if (number < 0)
                return "negative";
            if (number == 0)
                return "zero";

            return "positive";
        }
    }
}
