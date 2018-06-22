using System.Linq;

namespace Euler.Problems
{
    public class Problem5 : IProblem
    {
        public string Title => "Smallest multiple";

        public string Description => @"2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";

        public string GetSolution()
        {
            var numbers = Enumerable.Range(2, 20);

            var i = 20;
            while (true)
            {
                if (numbers.All(x => i % x == 0)) break;
                i += 20;
            }

            return i.ToString();
        }
    }
}
