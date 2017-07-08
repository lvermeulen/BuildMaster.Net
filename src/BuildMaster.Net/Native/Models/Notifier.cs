// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class Notifier
    {
        public int Notifier_Id { get; set; }
        public string Notifier_Name { get; set; }
        public string Notifier_Description { get; set; }
        public string Notifier_Configuration { get; set; }
        public string Owner_User_Name { get; set; }
        public bool Active_Indicator { get; set; }
    }
}
