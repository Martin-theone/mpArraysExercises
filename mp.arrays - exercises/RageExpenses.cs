using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class RageExpenses
    {
        public static void Run()
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = lostGames / 2;
            int mouseCount = lostGames / 3;
            int keyboardCount = lostGames / 6;
            int displayCount = keyboardCount / 2;

            double total = headsetCount * headsetPrice +
                           mouseCount * mousePrice +
                           keyboardCount * keyboardPrice +
                           displayCount * displayPrice;

            Console.WriteLine($"Rage expenses: {total:F2} lv.");
        }
    }
}
