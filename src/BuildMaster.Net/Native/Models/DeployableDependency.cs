// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class DeployableDependency
    {
        public int Deployable_Id { get; set; }
        public int DependsOn_Deployable_Id { get; set; }
    }
}
