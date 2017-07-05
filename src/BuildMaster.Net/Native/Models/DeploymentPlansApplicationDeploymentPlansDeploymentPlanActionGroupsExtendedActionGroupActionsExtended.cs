using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class DeploymentPlansApplicationDeploymentPlansDeploymentPlanActionGroupsExtendedActionGroupActionsExtended
    {
        public List<DeploymentPlan> DeploymentPlans { get; set; }
        public List<ApplicationDeploymentPlan> ApplicationDeploymentPlans { get; set; }
        public List<DeploymentPlanActionGroupExtended> DeploymentPlanActionGroups_Extended { get; set; }
        public List<ActionGroupActionExtended> ActionGroupActions_Extended { get; set; }
    }
}
