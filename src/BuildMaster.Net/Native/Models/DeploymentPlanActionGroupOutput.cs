using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class DeploymentPlanActionGroupOutput
    {
        public List<DeploymentPlanActionGroupExtended> DeploymentPlanActionGroups_Extended { get; set; }
        public List<ActionGroupActionExtended> ActionGroupActions_Extended { get; set; }
        public List<ActionGroupUsageSlim> ActionGroupUsage_Slim { get; set; }
        public List<ApplicationDeploymentPlan> ApplicationDeploymentPlans { get; set; }
    }
}
