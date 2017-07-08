using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class LogMessageExtended
    {
        public int LogMessage_Id { get; set; }
        public DateTime Logged_Date { get; set; }
        public string Message_Text { get; set; }
        public string Category_Name { get; set; }
        public int Message_Level { get; set; }
        public byte[] Details_Bytes { get; set; }
        public int? Server_Id { get; set; }
        public string Server_Name { get; set; }
        public int? Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int? Schedule_Id { get; set; }
        public string Schedule_Name { get; set; }
        public int? Requirement_Id { get; set; }
        public string Requirement_Description { get; set; }
        public int? Requirement_Workflow_Id { get; set; }
        public int? Provider_Id { get; set; }
        public string Provider_Name { get; set; }
        public int? EventListener_Id { get; set; }
        public bool ShowNotification_Indicator { get; set; }
    }
}
