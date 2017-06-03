﻿using System;

namespace BuildMaster.Net.Common
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

        public static string Decapitalize(this string s)
        {
            if (!string.IsNullOrWhiteSpace(s))
            {
                s = char.ToLower(s[0]) + s.Substring(1);
            }

            return s;
        }

        public static string ToYnIndicator(this bool value) => value ? "Y" : "N";

        public static string ToTrueFalse(this bool? value) => value.HasValue ? ToTrueFalse(value.Value) : null;

        public static string ToTrueFalse(this bool value) => value ? "true" : "false";

        public static bool ToBool(this string s) => s.Equals("true", StringComparison.OrdinalIgnoreCase);
    }
}
