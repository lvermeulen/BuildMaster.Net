using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class DatabaseChangeScriptExecutionExtended
    {
        public int Execution_Id { get; set; }
        public int DatabaseConnection_Id { get; set; }
        public string ScriptIds_Csv { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public string ExecutionStatus_Code { get; set; }
        public string ExecutionRunState_Code { get; set; }
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int Environment_Id { get; set; }
        public string Environment_Name { get; set; }
        public int? Server_Id { get; set; }
        public string Server_Name { get; set; }
    }
}
