// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class DeploymentPlan
    {
        public int DeploymentPlan_Id { get; set; }
        public string DeploymentPlan_Name { get; set; }
        public bool AllowLocalChanges_Indicator { get; set; }
        public byte[] OtterScript_Bytes { get; set; }
        public int? Application_Id { get; set; }
    }
}
