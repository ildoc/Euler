using Extensions;

namespace Euler.Problems
{
    public class Problem4 : IProblem
    {
        public string Title => "Largest palindrome product";

        public string Description => @"A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.";

        public string GetSolution()
        {
            var n = 0;
            var s = "";
            for (var x = 999; x >= 100; x--)
            {
                for (var y = 999; y >= 100; y--)
                {
                    s = (x * y).ToString();
                    if (s.Reverse() == s)
                        if (x * y > n) n = x * y;
                }
            }
            return n.ToString();
        }
    }
}
