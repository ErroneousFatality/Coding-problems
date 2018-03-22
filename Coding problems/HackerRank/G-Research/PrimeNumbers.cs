using System;
using System.Collections.Generic;

namespace ConsoleApplication1.HackerRank.G_Research
{
    static class PrimeNumbers
    {
        static IEnumerable<int> FindPrimeNumbers(int val)
        {
            if (val < 2)
            {
                return new List<int>(0);
            }

            List<int> primeNumbers = new List<int>((int)Math.Sqrt(val) / 2) { 2 };
            for (int i = 3; i <= val; i += 2)
            {
                if (isPrime(i, primeNumbers))
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }
        static bool isPrime(int x, List<int> primeNumbers)
        {
            int squareRoot = (int)Math.Sqrt(x);
            int squareRootInd = primeNumbers.BinarySearch(squareRoot);
            if (squareRootInd < 0)
            {
                squareRootInd = ~squareRootInd;
            }
            else
            {
                // increment the index so that the root is tested too since for goes to < not <=
                squareRootInd++;
            }
            for (int i = 0; i < squareRootInd; i++)
            {
                if (x % primeNumbers[i] == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
