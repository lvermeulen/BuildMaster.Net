using System;

namespace BuildMaster.Net.Models
{
    public class YnIndicator
    {
        public string Value { get; set; }

        public bool ToBool() => Value.Equals("Y", StringComparison.OrdinalIgnoreCase);
    }
}
