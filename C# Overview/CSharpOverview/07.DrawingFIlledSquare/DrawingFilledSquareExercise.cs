using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.DrawingFIlledSquare
{
    class DrawingFilledSquareExercise
    {
        static void Main(string[] args)
        {
            int squareSize = int.Parse(
                Console.ReadLine());

            DrawTop(squareSize);
            DrawMiddlePart(squareSize);
            DrawTop(squareSize);
        }

        private static void DrawTop(int squareSize)
        {
            Console.WriteLine(new string('-', 2 * squareSize));
        }

        private static void DrawMiddlePart(int squareSize)
        {
            Console.Write("-");

            for (int i = 1; i <= squareSize - 2; i++)
            {
                Console.Write(@"\/");
            }

            Console.WriteLine("-");
        }
    }
}
