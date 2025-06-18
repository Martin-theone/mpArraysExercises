using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class ChangeCalculator
    {
        public static void Run()
        {
            double change = double.Parse(Console.ReadLine());
            int cents = (int)Math.Round(change * 100);
            int[] coins = { 200, 100, 50, 20, 10, 5, 2, 1 };

            int count = 0;
            foreach (int coin in coins)
            {
                while (cents >= coin)
                {
                    cents -= coin;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
