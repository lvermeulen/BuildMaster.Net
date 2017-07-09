using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class Provider
    {
        public int Provider_Id { get; set; }
        public string ProviderType_Code { get; set; }
        public string Provider_Name { get; set; }
        public string Provider_Description { get; set; }
        public string Provider_Configuration { get; set; }
        public int? ExecuteOn_Server_Id { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public DateTime? ModifiedOn_Date { get; set; }
        public bool Internal_Indicator { get; set; }
    }
}
