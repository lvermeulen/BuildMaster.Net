using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class PlanExtended
    {
        public int Plan_Id { get; set; }
        public string Plan_Name { get; set; }
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public string PlanType_Code { get; set; }
        public byte[] Plan_Bytes { get; set; }
        public DateTime? ModifiedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public int? Environment_Id { get; set; }
        public string Environment_Name { get; set; }
    }
}
