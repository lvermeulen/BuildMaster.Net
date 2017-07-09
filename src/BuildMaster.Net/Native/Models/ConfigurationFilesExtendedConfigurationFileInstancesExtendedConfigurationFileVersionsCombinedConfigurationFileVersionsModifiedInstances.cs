using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ConfigurationFilesExtendedConfigurationFileInstancesExtendedConfigurationFileVersionsCombinedConfigurationFileVersionsModifiedInstances
    {
        public List<ConfigurationFileExtended> ConfigurationFiles_Extended { get; set; }
        public List<ConfigurationFileInstanceExtended> ConfigurationFileInstances_Extended { get; set; }
        public List<ConfigurationFileVersionCombined> ConfigurationFileVersions_Combined { get; set; }
        public List<ConfigurationFileVersionModifiedInstance> ConfigurationFileVersions_ModifiedInstances { get; set; }
    }
}
