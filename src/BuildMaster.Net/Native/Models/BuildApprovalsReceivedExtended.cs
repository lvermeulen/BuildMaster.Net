using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildApprovalsReceivedExtended
    {
        public int Approval_Id { get; set; }
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int Release_Id { get; set; }
        public string Release_Number { get; set; }
        public string Release_Name { get; set; }
        public int Build_Id { get; set; }
        public string Build_Number { get; set; }
        public int Original_Requirement_Id { get; set; }
        public string User_Name { get; set; }
        public string Comments_Text { get; set; }
        public DateTime? Received_Date { get; set; }
        public string RequirementType_Code { get; set; }
        public string Requirement_Description { get; set; }
        public int? Pipeline_Id { get; set; }
        public string PipelineStage_Name { get; set; }
    }
}
