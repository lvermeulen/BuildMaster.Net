using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class DeploymentPlanActionGroupExtended
    {
        public int DeploymentPlanActionGroup_Id { get; set; }
        public int DeploymentPlanActionGroup_Sequence { get; set; }
        public int DeploymentPlan_Id { get; set; }
        public string Deployable_Name { get; set; }
        public bool Active_Indicator { get; set; }
        public string ActionGroup_Name { get; set; }
        public string ActionGroup_Description { get; set; }
        public string Predicate_Configuration { get; set; }
        public int? Server_Id { get; set; }
        public string Server_Variable_Name { get; set; }
        public string ServerType_Code { get; set; }
        public string Server_Name { get; set; }
        public bool Iterate_Servers_Indicator { get; set; }
        public bool Iterate_Deployables_Indicator { get; set; }
        public bool Parallel_Indicator { get; set; }
        public int? OnSuccess_DeploymentPlanActionGroup_Id { get; set; }
        public int? OnSuccess_DeploymentPlanActionGroup_Sequence { get; set; }
        public string OnSuccess_DeploymentPlanActionGroup_Name { get; set; }
        public int? OnFailure_DeploymentPlanActionGroup_Id { get; set; }
        public int? OnFailure_DeploymentPlanActionGroup_Sequence { get; set; }
        public string OnFailure_DeploymentPlanActionGroup_Name { get; set; }
        public bool? OnFailure_Continue_Indicator { get; set; }
        public string DeploymentPlanActionGroup_ActionGroup_Name { get; set; }
        public string DeploymentPlanActionGroup_ActionGroup_Description { get; set; }
        public string DeploymentPlanActionGroup_Predicate_Configuration { get; set; }
        public string DeploymentPlanActionGroup_ModifiedBy_User_Name { get; set; }
        public DateTime? DeploymentPlanActionGroup_ModifiedOn_Date { get; set; }
        public int? DeploymentPlanActionGroup_Server_Id { get; set; }
        public string DeploymentPlanActionGroup_Server_Variable_Name { get; set; }
        public int ActionGroup_Id { get; set; }
        public string ActionGroup_CreatedBy_User_Name { get; set; }
        public DateTime? ActionGroup_CreatedOn_Date { get; set; }
        public string ActionGroup_ModifiedBy_User_Name { get; set; }
        public DateTime? ActionGroup_ModifiedOn_Date { get; set; }
        public string ActionGroup_ActionGroup_Name { get; set; }
        public string ActionGroup_Predicate_Configuration { get; set; }
        public string ActionGroup_ActionGroup_Description { get; set; }
        public int? ActionGroup_Server_Id { get; set; }
        public string ActionGroup_Server_Variable_Name { get; set; }
        public int? Referenced_Application_Id { get; set; }
        public string Referenced_Application_Name { get; set; }
        public int? DeploymentPlanActionGroup_Count { get; set; }
    }
}
