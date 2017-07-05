using System.Collections.Generic;

namespace BuildMaster.Net.Native.Models
{
    public class DeploymentPlansApplicationDeploymentPlans
    {
        public List<DeploymentPlan> DeploymentPlans { get; set; }
        public List<ApplicationDeploymentPlan> ApplicationDeploymentPlans { get; set; }
    }
}
