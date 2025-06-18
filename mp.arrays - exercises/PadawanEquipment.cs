using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class PadawanEquipment
    {
        public static void Run()
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int sabersCount = (int)Math.Ceiling(students * 1.1);
            int freeBelts = students / 6;

            double totalCost = (sabersCount * lightsaberPrice) +
                               (students * robePrice) +
                               ((students - freeBelts) * beltPrice);

            if (totalCost <= money)
                Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
            else
                Console.WriteLine($"George Lucas will need {(totalCost - money):F2}lv more.");
        }
    }
}
