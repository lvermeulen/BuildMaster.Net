namespace BuildMaster.Net.Common.Models
{
    public class SensitiveVariable : Variable
    {
        public bool? Sensitive { get; set; } // A boolean to indicate a sensitive variable that's obscured from casual viewing in the UI
    }
}
