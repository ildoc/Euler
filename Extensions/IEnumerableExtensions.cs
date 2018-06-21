using System;
using System.Collections;
using System.Collections.Generic;
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

        public static IEnumerable<int> BackTo(this int start, int end)
        {
            for (var i = start; i >= end; --i)
                yield return i;
        }
    }
}
