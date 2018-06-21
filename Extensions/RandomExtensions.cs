using System;

namespace Extensions
{
    public static class RandomExtensions
    {
        public static DateTime NextDatetime(this Random _random) => NextDatetime(_random, new DateTime(1970, 1, 1), new DateTime(2099, 1, 1));
        public static DateTime NextDatetime(this Random _random, DateTime from, DateTime to) =>
             from + new TimeSpan((long)(_random.NextDouble() * (to - from).Ticks));
    }
}
