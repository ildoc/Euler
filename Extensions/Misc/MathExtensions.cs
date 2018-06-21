using System;

namespace Extensions.Misc
{
    public static class MathExtensions
    {
        public static bool IsPrime(this int n) => ((long)n).IsPrime();
        public static bool IsPrime(this long n)
        {
            var i = 3;
            var limit = Math.Sqrt(n);
            if (n == 2 || n == 3) return true;
            if (n < 2 || n % 2 == 0 || n % 3 == 0) return false;
            while (i <= limit)
            {
                if (n % i == 0) return false;
                i += 2;
            }
            return true;
        }
    }
}
