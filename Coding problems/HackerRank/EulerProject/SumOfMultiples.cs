using System;

namespace ConsoleApplication1.HackerRank.EulerProject
{
    public static class SumOfMultiples
    {
        public static void Test()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(SumOfMultiplesOf3And5Below(n));
            }
        }

        public static ulong SumOfMultiplesOf3And5Below(int n)
        {
            int nMinusOne = n - 1;
            ulong threeSum = 3 * sumRangeUpTo(nMinusOne / 3);
            ulong fiveSum = 5 * sumRangeUpTo(nMinusOne / 5);
            ulong repeatingNumbersSum = 15 * sumRangeUpTo(nMinusOne / 15);
            return threeSum + fiveSum - repeatingNumbersSum;
        }

        static private ulong sumRangeUpTo(int n)
        {
            ulong un = (ulong)n;
            return ((un + 1) * un) / 2;
        }
    }
}
