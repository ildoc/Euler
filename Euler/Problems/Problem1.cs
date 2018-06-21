﻿using System.Linq;

namespace Euler.Problems
{
    public class Problem1 : IProblem
    {
        public string Title => "Multiples of 3 and 5";

        public string Description => @"If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.";

        public string GetSolution()
        {
            return Enumerable.Range(1, 999)
                 .Where(x => (x % 3 == 0) || (x % 5 == 0))
                 .Sum()
                 .ToString();
        }
    }
}
