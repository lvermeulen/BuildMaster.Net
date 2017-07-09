using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class DatabaseChangeScriptExtended
    {
        public int Script_Id { get; set; }
        public int Application_Id { get; set; }
        public int Release_Id { get; set; }
        public string Release_Number { get; set; }
        public int? Deployable_Id { get; set; }
        public string Script_Name { get; set; }
        public string Script_Text { get; set; }
        public bool Active_Indicator { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime CreatedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public DateTime ModifiedOn_Date { get; set; }
        public string Application_Name { get; set; }
        public long Numeric_Release_Number { get; set; }
        public string Deployable_Name { get; set; }
        public string Release_Name { get; set; }
        public Guid Script_Guid { get; set; }
    }
}
