using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildOutputExtended
    {
        public int Execution_Id { get; set; }
        public int Output_Sequence { get; set; }
        public string Output_Name { get; set; }
        public byte[] Output_Bytes { get; set; }
        public string OutputType_Code { get; set; }
        public int Application_Id { get; set; }
        public int Release_Id { get; set; }
        public string Release_Number { get; set; }
        public int Build_Id { get; set; }
        public string Build_Number { get; set; }
        public int Promotion_Id { get; set; }
        public string PipelineStage_Name { get; set; }
        public int? Environment_Id { get; set; }
        public string Environment_Name { get; set; }
        public DateTime? ExecutionStart_Date { get; set; }
        public string ExecutionStatus_Name { get; set; }
    }
}
