using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class PasswordGenerator
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 0; k < l; k++)
                    {
                        for (int m = 0; m < l; m++)
                        {
                            for (int p = 1; p <= n; p++)
                            {
                                if (p > i)
                                {
                                    Console.WriteLine($"{i}{j}{alphabet[k]}{alphabet[m]}{p}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
