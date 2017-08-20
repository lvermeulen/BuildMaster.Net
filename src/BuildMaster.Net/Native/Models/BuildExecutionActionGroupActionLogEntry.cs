// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildExecutionActionGroupActionLogEntry
    {
        public int LogEntry_Sequence { get; set; }
        public int LogEntry_Level { get; set; }
        public string LogEntry_Text { get; set; }
        public int BuildExecution_ActionGroupAction_Id { get; set; }
    }
}