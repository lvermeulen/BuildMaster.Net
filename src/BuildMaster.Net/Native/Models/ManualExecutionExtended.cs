using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ManualExecutionExtended
    {
        public int Execution_Id { get; set; }
        public string ExecutionType_Name { get; set; }
        public string Execution_Configuration { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public string ExecutionStatus_Code { get; set; }
        public string ExecutionRunState_Code { get; set; }
    }
}
