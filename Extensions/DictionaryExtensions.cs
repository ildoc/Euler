using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    public static class DictionaryExtensions
    {
        public static void RemoveAll<TKey, TValue>(this Dictionary<TKey, TValue> dict, Func<KeyValuePair<TKey, TValue>, bool> condition)
        {
            foreach (var cur in dict.Where(condition).ToList())
            {
                dict.Remove(cur.Key);
            }
        }

        public static void Each<TKey, TValue>(this Dictionary<TKey, TValue> dict, Action<TKey, TValue> action) =>
            dict.Each(x => action(x.Key, x.Value));

        public static TValue GetValue<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key) =>
            dict.TryGetValue(key, out TValue value) ?
            value :
            throw new KeyNotFoundException($"'{key}' not found in Dictionary");

        public static Dictionary<TValue, TKey> SwapKeyValue<TKey, TValue>(this Dictionary<TKey, TValue> dict) =>
            dict.ToDictionary(x => x.Value, x => x.Key);
    }
}
