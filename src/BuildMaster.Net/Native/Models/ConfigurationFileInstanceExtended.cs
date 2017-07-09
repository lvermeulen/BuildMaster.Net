using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ConfigurationFileInstanceExtended
    {
        public int ConfigurationFile_Id { get; set; }
        public string Instance_Name { get; set; }
        public bool Active_Indicator { get; set; }
        public int? Environment_Id { get; set; }
        public string Environment_Name { get; set; }
        public int? Display_Sequence { get; set; }
        public int? Deployable_Id { get; set; }
        public string FilePath_Text { get; set; }
        public bool ConfigurationFile_Active_Indicator { get; set; }
        public int Application_Id { get; set; }
        public int? LatestVersion_Version_Number { get; set; }
        public string LatestVersion_VersionNotes_Text { get; set; }
        public DateTime? LatestVersion_File_Date { get; set; }
        public byte[] LatestVersion_File_Bytes { get; set; }
        public DateTime? LatestVersion_CreatedOn_Date { get; set; }
        public string LatestVersion_CreatedByUser_Name { get; set; }
        public bool Template_Indicator { get; set; }
        public string Template_Instance_Name { get; set; }
        public int? Template_Instance_Count { get; set; }
        public string TransformType_Code { get; set; }
    }
}
