using System.Linq;
using EulerLib;

namespace Euler.Problems
{
    public class Problem3 : IProblem
    {
        public string Title => "Largest prime factor";

        public string Description => @"The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?";

        public string GetSolution()
        {
            return 600851475143.Factorize()
                .Max()
                .ToString();
        }
    }
}
