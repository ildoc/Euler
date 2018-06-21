using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Extensions
{
    public static class GenericExtensions
    {
        public static bool IsIn<T>(this T value, T[] stringValues) => stringValues.Contains(value);
        public static bool IsIn<T>(this T value, IEnumerable<T> stringValues) => value.IsIn(stringValues.ToArray());
        public static bool IsNotIn<T>(this T value, T[] stringValues) => !value.IsIn(stringValues);
        public static bool IsNotIn<T>(this T value, IEnumerable<T> stringValues) => !value.IsIn(stringValues);
        public static bool IsNotNull<T>(this T value) => !EqualityComparer<T>.Default.Equals(value, default);

        public static T CastTo<T>(this object obj) => (T)Convert.ChangeType(obj, typeof(T));
        public static T TimeoutFunc<T>(Func<T> func, int timeout, string timeoutMessage = null)
        {
            var task = Task.Run(func);
            if (timeout > 0 && !task.Wait(TimeSpan.FromSeconds(timeout)))
                throw string.IsNullOrEmpty(timeoutMessage)? new TimeoutException() : new TimeoutException(timeoutMessage);
            return task.Result;
        }
    }
}
