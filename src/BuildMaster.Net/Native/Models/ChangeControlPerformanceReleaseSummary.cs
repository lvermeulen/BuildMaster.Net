using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ChangeControlPerformanceReleaseSummary
    {
        public int ChangeControl_Id { get; set; }
        public string Environment_Name { get; set; }
        public int Environment_Id { get; set; }
        public int? ChangeControlPerformance_Id { get; set; }
        public string Notes_Text { get; set; }
        public string PerformedBy_User_Name { get; set; }
        public DateTime? Performed_Date { get; set; }
        public bool ChangeControlPerformed_Indicator { get; set; }
    }
}
