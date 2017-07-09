using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ChangeControlExtended
    {
        public int ChangeControl_Id { get; set; }
        public bool Active_Indicator { get; set; }
        public string ChangeControl_Name { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime CreatedOn_Date { get; set; }
        public string Description_Text { get; set; }
        public string Group_Name { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public DateTime ModifiedOn_Date { get; set; }
        public string PerformanceType_Code { get; set; }
        public string Principal_Name { get; set; }
        public string PrincipalType_Code { get; set; }
        public int Release_Id { get; set; }
        public string Release_Number { get; set; }
        public string Release_Name { get; set; }
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
    }
}
