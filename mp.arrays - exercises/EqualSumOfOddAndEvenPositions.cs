using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class EqualSumOfOddAndEvenPositions
    {
        public static void Run()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            bool found = false;

            for (int num = start; num <= end; num++)
            {
                string numStr = num.ToString();
                int oddSum = 0;
                int evenSum = 0;

                for (int i = 0; i < numStr.Length; i++)
                {
                    int digit = numStr[i] - '0';  // Convert char to digit
                    if (i % 2 == 0)
                    {
                        oddSum += digit;
                    }
                    else
                    {
                        evenSum += digit;
                    }
                }

                if (oddSum == evenSum)
                {
                    Console.WriteLine(num);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("None");
            }
        }
    }
}
