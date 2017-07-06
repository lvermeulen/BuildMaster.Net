using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ApplicationsExtendedDeployablesExtended
    {
        public List<ApplicationExtended> Applications_Extended { get; set; }
        public List<DeployableExtended> Deployables_Extended { get; set; }
    }
}
