﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Utils
{
    public static class For
    {
        [DebuggerStepThrough]
        public static void Each<T>(IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }

        /// <summary>
        ///     For shortcut, no side effects
        /// </summary>
        [DebuggerStepThrough]
        public static void Each<T>(IEnumerable source, Action<T> action)
        {
            foreach (var item in source)
                action((T)item);
        }
    }
}
