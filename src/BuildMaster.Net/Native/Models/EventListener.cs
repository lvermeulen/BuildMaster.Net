// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class EventListener
    {
        public int EventListener_Id { get; set; }
        public string EventListener_Description { get; set; }
        public string EventListener_Configuration { get; set; }
        public string Owner_User_Name { get; set; }
        public bool Active_Indicator { get; set; }
        public int? WorkflowStep_Workflow_Id { get; set; }
        public int? WorkflowStep_Environment_Id { get; set; }
        public int? BuildStep_Workflow_Id { get; set; }
    }
}