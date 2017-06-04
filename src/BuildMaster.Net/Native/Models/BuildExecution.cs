using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildExecution
    {
        public List<BuildExecutionsExtended> BuildExecutions_Extended { get; set; }
        public List<BuildExecutionDeploymentPlan> BuildExecution_DeploymentPlans { get; set; }
        public List<BuildExecutionDeploymentPlanActionGroup> BuildExecution_DeploymentPlanActionGroups { get; set; }
        public List<BuildExecutionActionGroupAction> BuildExecution_ActionGroupActions { get; set; }
        public List<BuildExecutionActionGroupActionLogEntry> BuildExecution_ActionGroupActionLogEntries { get; set; }
    }
}
