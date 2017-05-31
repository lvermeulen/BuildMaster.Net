﻿namespace BuildMaster.Net.Common
{
    public class NamedValue
    {
        public string Name { get; }
        public object Value { get; }

        public NamedValue(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }
}
