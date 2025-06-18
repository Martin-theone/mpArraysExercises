using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class HourglassPattern
    {
        public static void Run()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n;

            // Top half
            for (int i = 0; i < n; i++)
            {
                string line = "";

                for (int j = 0; j < width; j++)
                {
                    if (j == i || j == width - i - 1)
                        line += "#";
                    else if (i == 0)
                        line += "#";
                    else
                        line += " ";
                }

                Console.WriteLine(line);
            }

            // Bottom half
            for (int i = n - 1; i >= 0; i--)
            {
                string line = "";

                for (int j = 0; j < width; j++)
                {
                    if (j == i || j == width - i - 1)
                        line += "#";
                    else if (i == 0)
                        line += "#";
                    else
                        line += " ";
                }

                Console.WriteLine(line);
            }
        }
    }
}