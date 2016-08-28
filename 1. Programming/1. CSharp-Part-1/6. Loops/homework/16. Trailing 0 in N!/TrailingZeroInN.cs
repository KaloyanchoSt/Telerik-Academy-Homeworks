﻿using System;

namespace _16.Trailing_0_in_N_
{
    class TrailingZeroInN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int zeroCount = 0;
            int d;

            for (int i = 5; i <= n; i += 5)
            {
                d = i;
                while (d % 5 == 0)
                {
                    d /= 5;
                    zeroCount++;
                }
            }

            Console.WriteLine(zeroCount);
        }
    }
}
