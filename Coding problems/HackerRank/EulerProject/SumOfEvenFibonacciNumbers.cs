namespace ConsoleApplication1.HackerRank.EulerProject
{
    class SumOfEvenFibonacciNumbers
    {
        static long SumEvenFibonacciNumbers(long n)
        {
            if (n < 2)
            {
                return 0;
            }
            long a = 1, b = 2;
            long sum = 2;
            while (takeNextFibonacciStepAndSumEvenNumber(ref a, b, n, ref sum) 
                && takeNextFibonacciStepAndSumEvenNumber(ref b, a, n, ref sum)
            );
            return sum;
        }
        private static bool takeNextFibonacciStepAndSumEvenNumber(ref long a, long b, long n, ref long sum)
        {
            a += b;
            if (a > n)
            {
                return false;
            }
            if (a % 2 == 0)
            {
                sum += a;
            }
            return true;
        }
    }
}
