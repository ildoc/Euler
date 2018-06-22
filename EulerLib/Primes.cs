using System;
using System.Collections.Generic;
using System.Linq;
using Extensions.Misc;

namespace EulerLib
{
    public static class Primes
    {
        public static ICollection<int> GetPrimes(int max)
        {
            var n = 3;
            var result = new List<int> { 2 };
            var prime = true;
            while (result.Count < max)
            {
                prime = true;
                foreach (var x in result.Take((int)Math.Round(Math.Sqrt(result.Count))))
                {
                    if (n % x == 0) { prime = false; break; }
                }
                if (prime) result.Add(n);
                n += 2;
            }

            return result;
        }

        public static ICollection<long> GetPrimesUnderN(long max)
        {
            var n = 3;
            var result = new List<long> { 2 };
            var prime = true;
            while (n < max)
            {
                prime = true;
                foreach (var x in result.Take((int)Math.Round(Math.Sqrt(result.Count))))
                {
                    if (n % x == 0) { prime = false; break; }
                }
                if (prime) result.Add(n);
                n += 2;
            }
            return result;
        }

        public static IEnumerable<int> Factorize(this int n) => Factorize((long)n).Select(x => (int)x);
        public static IEnumerable<long> Factorize(this long n)
        {
            var i = 2;
            var result = new List<long>();
            while (n != 1)
            {
                if (i.IsPrime() && n % i == 0)
                {
                    n /= i;
                    result.Add(i);
                    i = 1;
                }
                i++;
            }

            return result;
        }

    }
}
