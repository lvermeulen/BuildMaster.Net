using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildScheduleExtendedBuildScheduleVariableDefinitionsExtended
    {
        public List<BuildScheduleExtended> BuildSchedules_Extended { get; set; }
        public List<BuildScheduleVariableDefinitionExtended> BuildScheduleVariableDefinitions_Extended { get; set; }
    }
}
