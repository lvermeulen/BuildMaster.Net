// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ActionGroupUsageSlim
    {
        public int ActionGroup_Id { get; set; }
        public int DeploymentPlanActionGroup_Id { get; set; }
        public string DeploymentPlan_Name { get; set; }
        public int? Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int? ApplicationGroup_Id { get; set; }
        public string ApplicationGroup_Name { get; set; }
        public int? Environment_Id { get; set; }
        public string Environment_Name { get; set; }
    }
}
