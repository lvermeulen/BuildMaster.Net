using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ApplicationExtended
    {
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public string Application_Description { get; set; }
        public string ReleaseNumber_Scheme_Name { get; set; }
        public string BuildNumber_Scheme_Name { get; set; }
        public bool AllowMultipleActiveBuilds_Indicator { get; set; }
        public int? IssueTracking_Provider_Id { get; set; }
        public string IssueTracking_CategoryIdList_Text { get; set; }
        public string IssueTracking_Filter_Configuration { get; set; }
        public bool IssueTracking_AllowBuildMasterIssues_Indicator { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public DateTime? ModifiedOn_Date { get; set; }
        public string Dashboard_Text { get; set; }
        public int? ApplicationGroup_Id { get; set; }
        public string ApplicationGroup_Name { get; set; }
        public string ApplicationGroup_Description { get; set; }
        public int? Active_Releases_Count { get; set; }
        public string VariableSupport_Code { get; set; }
        public DateTime? Issues_LastSynchronized_Date { get; set; }
        public bool ShowDeployables_Indicator { get; set; }
        public bool Active_Indicator { get; set; }
    }
}
