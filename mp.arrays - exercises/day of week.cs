using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    using System;
    internal class DayOfTheWeek
    {
        // Method to print the corresponding day of the week based on the input number
        public static void PrintDayOfWeek(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }
        }

        // Main entry point
        public static void Run()
        {
            // Prompt the user to enter a day number
            Console.Write("Enter a number (1-7) to get the corresponding day of the week: ");
            int dayNumber = int.Parse(Console.ReadLine());

            // Call the method to print the day of the week
            PrintDayOfWeek(dayNumber);
        }
    }
}

