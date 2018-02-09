using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ApplicationLatestEnvironmentExecution
    {
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int? ApplicationGroup_Id { get; set; }
        public string ApplicationGroup_Name { get; set; }
        public int Release_Id { get; set; }
        public string Release_Number { get; set; }
        public string Release_Name { get; set; }
        public int Promotion_Id { get; set; }
        public string PromotionStatus_Name { get; set; }
        public int Build_Id { get; set; }
        public string Build_Number { get; set; }
        public string BuildStatus_Name { get; set; }
        public int Environment_Id { get; set; }
        public string Environment_Name { get; set; }
        public int Execution_Id { get; set; }
        public DateTime? ExecutionStart_Date { get; set; }
        public string ExecutionStatus_Code { get; set; }
        public string ExecutionRunState_Code { get; set; }
    }
}
