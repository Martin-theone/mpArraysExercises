using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class MultiplyBigNumber
    {
        public static void Run()
        {
            string bigNumber = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0 || string.IsNullOrEmpty(bigNumber))
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder result = new StringBuilder();
            int carry = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(bigNumber[i].ToString());
                int product = digit * multiplier + carry;
                carry = product / 10;
                result.Insert(0, product % 10);
            }

            if (carry > 0)
            {
                result.Insert(0, carry);
            }

            Console.WriteLine(result);
        }
    }
}