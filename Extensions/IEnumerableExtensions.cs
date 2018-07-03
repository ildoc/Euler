using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Utils;

namespace Extensions
{
    public static class IEnumerableExtensions
    {
        public static void Each<T>(this IEnumerable<T> source, Action<T> action)
        {
            For.Each(source, action);
        }

        public static void Each<T>(this IEnumerable source, Action<T> action)
        {
            For.Each(source, action);
        }

        public static IEnumerable<int> To(this int start, int end)
        {
            for (var i = start; i <= end; ++i)
                yield return i;
        }

        public static IEnumerable<long> To(this long start, long end)
        {
            for (var i = start; i <= end; ++i)
                yield return i;
        }

        public static IEnumerable<int> BackTo(this int start, int end)
        {
            for (var i = start; i >= end; --i)
                yield return i;
        }
        public static string ToString(this IEnumerable<char> chars)
        {
            return new string(chars.ToArray());
        }

        public static int Multiply(this IEnumerable<int> ints)
        {
            var res = 1;
            ints.Each(x => res *= x);
            return res;
        }

    }
}
