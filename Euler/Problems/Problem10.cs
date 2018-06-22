using System.Linq;
using EulerLib;

namespace Euler.Problems
{
    public class Problem10 : IProblem
    {
        public string Title => "Summation of primes";

        public string Description => @"The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.";

        public string GetSolution()
        {
            return Primes.GetPrimesUnderN(2000000).Sum().ToString();
        }
    }
}
