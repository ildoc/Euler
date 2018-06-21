using System;

namespace Utils
{
    public static class _
    {
        public static bool Try(Action a)
        {
            try
            {
                a();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static T Try<T>(Func<T> f)
        {
            try
            {
                return f();
            }
            catch
            {
            }
            return default(T);
        }
    }
}
