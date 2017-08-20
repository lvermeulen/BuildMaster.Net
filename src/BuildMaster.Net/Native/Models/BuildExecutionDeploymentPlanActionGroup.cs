// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildExecutionDeploymentPlanActionGroup
    {
        public int BuildExecution_DeploymentPlan_Id { get; set; }
        public int Original_DeploymentPlanActionGroup_Sequence { get; set; }
        public string Original_Deployable_Name { get; set; }
        public string Original_Deployable_Application_Name { get; set; }
        public int Original_DeploymentPlanActionGroup_Id { get; set; }
        public string Original_DeploymentPlanActionGroup_Name { get; set; }
    }
}