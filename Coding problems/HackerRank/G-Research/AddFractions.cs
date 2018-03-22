using ConsoleApplication1.Utils;
using System;

namespace ConsoleApplication1.HackerRank.G_Research
{
    class AddFractions
    {
        static Tuple<int, int> Add(int x, int y, int u, int v)
        {
            long b = MathHelpers.LeastCommonMultiple(y, v);
            long a = (long)(x * ((double)b / y) + u * ((double)b / v));
            long gcd = MathHelpers.GreatestCommonDivisor(a, b);

            a /= gcd;
            b /= gcd;

            return new Tuple<int, int>((int)a, (int)b);
        }
    }
}
