// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class Role
    {
        public int Role_Id { get; set; }
        public string Role_Name { get; set; }
        public string Role_Description { get; set; }
        public bool Application_Scopeable_Indicator { get; set; }
        public bool Environment_Scopeable_Indicator { get; set; }
    }
}