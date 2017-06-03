// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildPromotionsExtended
    {
        public int Application_Id { get; set; }
        public int Release_Id { get; set; }
        public string Release_Number { get; set; }
        public int Build_Id { get; set; }
        public string Build_Number { get; set; }
        public int Promotion_Id { get; set; }
        public string Promoted_Date { get; set; }
        public string PromotedBy_Name { get; set; }
        public object Comments_Text { get; set; }
        public string PromotionStatus_Name { get; set; }
        public string StatusOverriddenBy_User_Name { get; set; }
        public string StatusOverriddenReason_Text { get; set; }
        public string StatusOverridden_Date { get; set; }
        public bool Forced_Indicator { get; set; }
        public string Application_Name { get; set; }
        public string BuildStatus_Name { get; set; }
        public int Pipeline_Id { get; set; }
        public int Release_Sequence { get; set; }
        public int Last_Execution_Id { get; set; }
        public string Last_ExecutionStart_Date { get; set; }
        public string Last_ExecutionStatus_Name { get; set; }
        public string Release_Name { get; set; }
        public string PipelineStage_Name { get; set; }
    }
}
