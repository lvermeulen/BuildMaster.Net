// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildExecutionsExtended
    {
        public int Execution_Id { get; set; }
        public int Application_Id { get; set; }
        public int Release_Id { get; set; }
        public string Release_Number { get; set; }
        public int Build_Id { get; set; }
        public string Build_Number { get; set; }
        public string BuildStatus_Name { get; set; }
        public int Pipeline_Id { get; set; }
        public string Pipeline_Name { get; set; }
        public object Pipeline_Color { get; set; }
        public int Environment_Id { get; set; }
        public string Environment_Name { get; set; }
        public int Promotion_Id { get; set; }
        public string PipelineStage_Name { get; set; }
        public string Plan_Name { get; set; }
        public string ExecutionStart_Date { get; set; }
        public string ExecutionEnded_Date { get; set; }
        public string ExecutionRunState_Code { get; set; }
        public string ExecutionStatus_Code { get; set; }
        public string ExecutionStatus_Name { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public string CreatedOn_Date { get; set; }
        public object CanceledBy_User_Name { get; set; }
        public object CanceledOn_Date { get; set; }
        public object LastActionReexecutionOf_Execution_Id { get; set; }
        public string Application_Name { get; set; }
        public string PromotionStatus_Name { get; set; }
        public string Promoted_Date { get; set; }
        public string PromotedBy_Name { get; set; }
        public bool WarningLogEntry_Indicator { get; set; }
        public string Release_Name { get; set; }
        public string ReleaseStatus_Name { get; set; }
        public object Initial_BuildExecution_DeploymentPlan_Id { get; set; }
        public object Initial_BuildExecution_DeploymentPlan_Name { get; set; }
        public string VariableSupport_Code { get; set; }
        public object ApplicationGroup_Id { get; set; }
        public int Release_Sequence { get; set; }
        public object ReexecutionState_Xml { get; set; }
        public string RunContextHash_Bytes { get; set; }
        public object BuildImporter_Configuration { get; set; }
        public object DependentUpon_Execution_Id { get; set; }
        public object PipelineStageTarget_Index { get; set; }
    }
}
