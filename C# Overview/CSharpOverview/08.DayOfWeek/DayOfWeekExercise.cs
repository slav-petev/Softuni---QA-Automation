using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.DayOfWeek
{
    class DayOfWeekExercise
    {
        static void Main(string[] args)
        {
            string[] weekDays =
            {
                "Monday", "Tuesday",
                "Wednesday", "Thursday",
                "Friday", "Saturday",
                "Sunday"
            };

            int day = int.Parse(
                Console.ReadLine());

            if (day <= 0 || day > weekDays.Length)
                Console.WriteLine("Invalid Day!");
            else
                Console.WriteLine(weekDays[day - 1]);
        }
    }
}
