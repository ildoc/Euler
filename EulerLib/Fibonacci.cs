using System.Collections.Generic;

namespace EulerLib
{
    public static class Fibonacci
    {
        public static IEnumerable<int> Sequence()
        {
            int first = 1;
            int second = 1;

            yield return first;
            yield return second;

            while (true)
            {
                int current = first + second;
                yield return current;

                first = second;
                second = current;
            }
        }
    }
}
