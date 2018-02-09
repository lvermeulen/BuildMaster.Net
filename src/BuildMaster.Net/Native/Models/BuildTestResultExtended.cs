using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildTestResultExtended
    {
        public int Execution_Id { get; set; }
        public string Group_Name { get; set; }
        public int Test_Sequence { get; set; }
        public string Test_Name { get; set; }
        public string TestStatus_Code { get; set; }
        public string TestResult_Text { get; set; }
        public DateTime? TestStarted_Date { get; set; }
        public DateTime? TestEnded_Date { get; set; }
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int Release_Id { get; set; }
        public string Release_Number { get; set; }
        public string Release_Name { get; set; }
    }
}
