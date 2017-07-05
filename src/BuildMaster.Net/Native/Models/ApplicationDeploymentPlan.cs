// ReSharper disable InconsistentNaming
namespace BuildMaster.Net.Native.Models
{
    public class ApplicationDeploymentPlan
    {
        public int DeploymentPlan_Id { get; set; }
        public string DeploymentPlan_Name { get; set; }
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int? ApplicationGroup_Id { get; set; }
        public string ApplicationGroup_Name { get; set; }
        public int? Environment_Id { get; set; }
        public string Environment_Name { get; set; }
        public int? Environment_Display_Sequence { get; set; }
        public int Workflow_Id { get; set; }
        public string Workflow_Name { get; set; }
        public int? Workflow_Step_Sequence { get; set; }
        public bool BuildStep_Indicator { get; set; }
        public bool AllowLocalChanges_Indicator { get; set; }
        public byte[] OtterScript_Bytes { get; set; }
        public bool DeploymentPlan_Shared_Indicator { get; set; }
    }
}
