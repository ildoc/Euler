using System.Linq;
using EulerLib;

namespace Euler.Problems
{
    public class Problem7 : IProblem
    {
        public string Title => "10001st prime";

        public string Description => @"By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?";

        public string GetSolution()
        {
            return Primes.GetPrimes(10001)
                .Last()
                .ToString();
        }
    }
}
