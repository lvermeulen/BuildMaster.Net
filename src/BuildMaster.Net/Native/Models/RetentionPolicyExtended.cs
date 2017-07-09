using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class RetentionPolicyExtended
    {
        public int RetentionPolicy_Id { get; set; }
        public string RetentionPolicy_Name { get; set; }
        public string PurgeType_Code { get; set; }
        public DateTime CreatedOn_Date { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? ModifiedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public int? PurgeIn_Application_Id { get; set; }
        public string PurgeIn_Application_Name { get; set; }
        public int? PurgeIn_ApplicationGroup_Id { get; set; }
        public string PurgeIn_ApplicationGroup_Name { get; set; }
        public int? PurgeIn_Workflow_Id { get; set; }
        public string PurgeIn_Workflow_Name { get; set; }
        public int? PurgeIn_Pipeline_Id { get; set; }
        public int? PurgeIn_Environment_Id { get; set; }
        public string PurgeIn_Environment_Name { get; set; }
        public bool PurgeIn_BuildStep_Indicator { get; set; }
        public bool PurgeIn_OnlyDeployedReleases_Indicator { get; set; }
        public bool PurgeIn_OnlyRejectedBuilds_Indicator { get; set; }
        public bool? PurgeOrphanedArtifacts_Indicator { get; set; }
        public int? Retention_Count { get; set; }
        public long? Retention_Size { get; set; }
        public int? Retention_Days_Count { get; set; }
        public int? PurgeWindow_Start_Minutes { get; set; }
        public int? PurgeWindow_Duration_Minutes { get; set; }
        public bool PurgeNow_Indicator { get; set; }
        public bool Active_Indicator { get; set; }
        public int? RetentionPoliciesPurgeHistoryEntry_Id { get; set; }
        public DateTime? LastStart_Date { get; set; }
    }
}
