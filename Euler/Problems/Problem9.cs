using System.Linq;

namespace Euler.Problems
{
    public class Problem9 : IProblem
    {
        public string Title => "Special Pythagorean triplet";

        public string Description => @"A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
a^2 + b^2 = c^2

For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.";

        public string GetSolution()
        {
            foreach (var a in Enumerable.Range(1, 500))
                foreach (var b in Enumerable.Range(1, 500))
                    if (a * a + b * b == (1000 - a - b) * (1000 - a - b)) return $"{a * b * (1000 - a - b)}";
            return "";
        }
    }
}
