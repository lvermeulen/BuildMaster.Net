// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildExecutionDeploymentPlan
    {
        public int BuildExecution_DeploymentPlan_Id { get; set; }
        public int Execution_Id { get; set; }
        public int Original_DeploymentPlan_Id { get; set; }
        public string Original_DeploymentPlan_Name { get; set; }
    }
}