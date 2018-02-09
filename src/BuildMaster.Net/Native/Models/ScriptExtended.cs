using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ScriptExtended
    {
        public int Script_Id { get; set; }
        public string Script_Name { get; set; }
        public string Description_Text { get; set; }
        public bool Active_Indicator { get; set; }
        public bool AutoSync_Indicator { get; set; }
        public string ScriptType_Code { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public DateTime? ModifiedOn_Date { get; set; }
        public int? LatestVersion_Number { get; set; }
        public byte[] LatestVersion_Bytes { get; set; }
    }
}
