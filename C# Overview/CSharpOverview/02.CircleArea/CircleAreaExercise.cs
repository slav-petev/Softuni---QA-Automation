using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CircleArea
{
    class CircleAreaExercise
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(
                Console.ReadLine());

            double circleArea = Math.PI *
                radius * radius;

            Console.WriteLine("{0:F12}", circleArea);
        }
    }
}
