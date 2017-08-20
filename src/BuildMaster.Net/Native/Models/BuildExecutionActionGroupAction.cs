using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildExecutionActionGroupAction
    {
        public DateTime ExecutionStarted_Date { get; set; }
        public DateTime? ExecutionEnded_Date { get; set; }
        public string ExecutionStatus_Name { get; set; }
        public string ExecutionAction_Description { get; set; }
        public int Original_Action_Sequence { get; set; }
        public int BuildExecution_ActionGroupAction_Id { get; set; }
        public string Original_Server_Name { get; set; }
        public int Attempt_Sequence { get; set; }
        public bool WarningLogEntry_Indicator { get; set; }
        public int? Nested_BuildExecution_DeploymentPlan_Id { get; set; }
        public int BuildExecution_DeploymentPlan_Id { get; set; }
        public int Original_DeploymentPlanActionGroup_Sequence { get; set; }
    }
}