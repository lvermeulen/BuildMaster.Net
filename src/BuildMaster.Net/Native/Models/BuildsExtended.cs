// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildsExtended
    {
        public int Release_Id { get; set; }
        public string Release_Number { get; set; }
        public int Build_Id { get; set; }
        public string Build_Number { get; set; }
        public string BuildStatus_Name { get; set; }
        public string Release_Name { get; set; }
        public object Target_Date { get; set; }
        public object Earliest_Target_Start_Date { get; set; }
        public object Latest_Target_End_Date { get; set; }
        public int Build_Sequence { get; set; }
        public int Pipeline_Id { get; set; }
        public string Pipeline_Name { get; set; }
        public object Pipeline_Color { get; set; }
        public string ReleaseStatus_Name { get; set; }
        public int Release_Sequence { get; set; }
        public object Release_Notes_Text { get; set; }
        public object Rejection_Notes { get; set; }
        public object RejectedBy_User_Name { get; set; }
        public object Rejected_Date { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public string CreatedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public string ModifiedOn_Date { get; set; }
        public object BuildImporter_Configuration { get; set; }
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int Latest_Promotion_Id { get; set; }
        public string Latest_Promotion_Date { get; set; }
        public string Latest_Promotion_Status { get; set; }
        public string Latest_PipelineStage_Name { get; set; }
        public string Furthest_PipelineStage_Name { get; set; }
        public int Latest_Execution_Id { get; set; }
        public int Latest_Execution_Environment_Id { get; set; }
        public string Latest_Execution_Environment_Name { get; set; }
        public string Latest_Execution_RunState_Code { get; set; }
        public string Latest_Execution_Status_Code { get; set; }
    }
}
