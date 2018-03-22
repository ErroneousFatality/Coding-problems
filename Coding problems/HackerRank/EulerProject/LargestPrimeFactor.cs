using System;
namespace ConsoleApplication1.HackerRank
{
    static class LargestPrimeFactor
    {
        public static void Test()
        {
            Console.WriteLine(FindLargestPrimeFactor(222));
        }

        static long FindLargestPrimeFactor(long n)
        {
            if (n <= 1)
            {
                return 1;
            }
            long largestPrimeFactor = 1;
            if (continuousDivide(ref n, 2))
            {
                largestPrimeFactor = 2;
            }
            long squareRoot = (long)Math.Sqrt(n);
            for (long i = 3; i <= squareRoot; i += 2)
            {
                if (continuousDivide(ref n, i))
                {
                    largestPrimeFactor = i;
                }
            }
            if (n > 1)
            {
                return n;
            }
            return largestPrimeFactor;
        }

        static bool continuousDivide(ref long n, long i)
        {
            if (n % i == 0)
            {
                do n /= i; while (n % i == 0);
                return true;
            }
            return false;
        }
    }
}
