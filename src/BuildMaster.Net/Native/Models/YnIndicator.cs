using System;

namespace BuildMaster.Net.Native.Models
{
    public class YnIndicator
    {
        public string Value { get; set; }

        public bool ToBool() => Value.Equals("Y", StringComparison.OrdinalIgnoreCase);
    }
}
