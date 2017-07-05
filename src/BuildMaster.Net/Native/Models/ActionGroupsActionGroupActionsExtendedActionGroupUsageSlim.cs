using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ActionGroupsActionGroupActionsExtendedActionGroupUsageSlim
    {
        public List<ActionGroup> ActionGroups { get; set; }
        public List<ActionGroupActionExtended> ActionGroupActions_Extended { get; set; }
        public List<ActionGroupUsageSlim> ActionGroupUsage_Slim { get; set; }
    }
}
