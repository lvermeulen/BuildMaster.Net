using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ConfigurationFileVersionExtended
    {
        public int ConfigurationFile_Id { get; set; }
        public string Instance_Name { get; set; }
        public int Version_Number { get; set; }
        public int? Environment_Id { get; set; }
        public string Environment_Name { get; set; }
        public bool Active_Indicator { get; set; }
        public int? Deployable_Id { get; set; }
        public string Deployable_Name { get; set; }
        public bool Template_Indicator { get; set; }
        public string Template_Instance_Name { get; set; }
        public string TransformType_Code { get; set; }
        public string FilePath_Text { get; set; }
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int? ApplicationGroup_Id { get; set; }
        public string ApplicationGroup_Name { get; set; }
        public string VersionNotes_Text { get; set; }
        public DateTime? File_Date { get; set; }
        public byte[] File_Bytes { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public bool? Null_Indicator { get; set; }
    }
}
