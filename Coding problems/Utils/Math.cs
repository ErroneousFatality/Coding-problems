namespace ConsoleApplication1.Utils
{
    public static class MathHelpers
    {
        public static long GreatestCommonDivisor(long a, long b)
        {
            while (b != 0)
            {
                long t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public static long LeastCommonMultiple(long a, long b)
        {
            long gcd = GreatestCommonDivisor(a, b);
            return (a / gcd) * b;
        }
    }
}
