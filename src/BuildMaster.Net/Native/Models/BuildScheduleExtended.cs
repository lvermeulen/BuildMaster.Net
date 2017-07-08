using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildScheduleExtended
    {
        public int Schedule_Id { get; set; }
        public string Schedule_Name { get; set; }
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public bool Active_Indicator { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public DateTime? ModifiedOn_Date { get; set; }
        public string Schedule_Type { get; set; }
        public short? StartTime_Minutes { get; set; }
        public short? EndTime_Minutes { get; set; }
        public short? DailyInterval_Minutes { get; set; }
        public string Recurrence_Type { get; set; }
        public int? RecurrenceFrequency_Value { get; set; }
        public string RecurrenceWeeklyDay_Mask { get; set; }
        public byte? RecurrenceMonthlyDay_Value { get; set; }
        public string RecurrenceMonthlyRelativity_Type { get; set; }
        public string RecurrenceMonthlyRelativityDay_Type { get; set; }
        public string RecurrenceMonthlyRelativityWeek_Type { get; set; }
        public byte? RecurrenceMonthlyRelativityWeekDay_Value { get; set; }
        public string Url_AllowedIP_CSV { get; set; }
        public string Url_Username_Text { get; set; }
        public string Url_Password_Text { get; set; }
        public string SourceControl_Path_Name { get; set; }
        public int? SourceControl_Provider_Id { get; set; }
        public string SourceControl_Provider_Name { get; set; }
        public short? SourceControl_QuietPeriod_Minutes { get; set; }
        public string ReleaseFilter_ReleaseType_Code { get; set; }
        public int? Releasefilter_Workflow_Id { get; set; }
        public string BuildImporter_Configuration { get; set; }
        public DateTime? LastExecution_Date { get; set; }
        public int? ReleaseFilter_Pipeline_Id { get; set; }
        public string ReleaseFilter_Release_Number { get; set; }
    }
}
