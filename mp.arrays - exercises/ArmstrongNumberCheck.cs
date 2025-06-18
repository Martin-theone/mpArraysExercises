using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class ArmstrongNumberCheck
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, temp = n;
            int digits = n.ToString().Length;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }

            Console.WriteLine(sum == n ? "true" : "false");
        }
    }

}
