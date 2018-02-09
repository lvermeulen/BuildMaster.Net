using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class IssueExtended
    {
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int? ApplicationGroup_Id { get; set; }
        public string ApplicationGroup_Name { get; set; }
        public int? Release_Id { get; set; }
        public string Release_Number { get; set; }
        public string Release_Name { get; set; }
        public long? Release_Sequence { get; set; }
        public int Issue_Id { get; set; }
        public string Type_Text { get; set; }
        public string Title_Text { get; set; }
        public string Description_Text { get; set; }
        public bool Closed_Indicator { get; set; }
        public DateTime? ClosedOn_Date { get; set; }
        public string OpenedOn_Original_Build_Number { get; set; }
        public int? OpenedOn_Original_Build_Sequence { get; set; }
        public string ClosedOn_Original_Build_Number { get; set; }
        public int? ClosedOn_Original_Build_Sequence { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public string IssueTracker_IssueId_Text { get; set; }
        public string IssueTracker_IssueStatus_Text { get; set; }
        public DateTime? IssueTracker_LastSync_Date { get; set; }
        public string IssueTracker_IssueUrl_Text { get; set; }
        public bool BuildMasterIssue_Indicator { get; set; }
    }
}
