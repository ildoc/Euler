using System.Linq;

namespace Euler.Problems
{
    public class Problem6 : IProblem
    {
        public string Title => "Sum square difference";

        public string Description => @"The sum of the squares of the first ten natural numbers is,
1^2 + 2^2 + ... + 10^2 = 385

The square of the sum of the first ten natural numbers is,
(1 + 2 + ... + 10)^2 = 55^2 = 3025

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.";

        public string GetSolution()
        {
            var numbers = Enumerable.Range(1, 100);
            return (numbers.Sum() * numbers.Sum() - numbers.Select(x => x * x).Sum()).ToString();
        }
    }
}
