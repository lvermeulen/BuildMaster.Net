// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ApplicationSlim
    {
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int? ApplicationGroup_Id { get; set; }
        public string ApplicationGroup_Name { get; set; }
        public bool Active_Indicator { get; set; }
        public int? Parent_ApplicationGroup_Id { get; set; }
    }
}
