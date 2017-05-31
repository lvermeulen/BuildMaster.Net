﻿using System;

namespace BuildMaster.Net
{
    public static class StringExtensions
    {
        public static string WithoutAsyncSuffix(this string s)
        {
            if (s.EndsWith("Async", StringComparison.OrdinalIgnoreCase))
            {
                return s.Substring(0, s.LastIndexOf("Async", StringComparison.OrdinalIgnoreCase));
            }

            return s;
        }

        public static string Capitalize(this string s)
        {
            if (!string.IsNullOrWhiteSpace(s))
            {
                s = char.ToUpper(s[0]) + s.Substring(1);
            }

            return s;
        }

        public static string ToYnIndicator(this bool value) => value ? "Y" : "N";
    }
}