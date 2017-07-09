using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ConfigurationFileVersionCombined
    {
        public int ConfigurationFile_Id { get; set; }
        public int Version_Number { get; set; }
        public string ConfigurationFile_Name { get; set; }
        public string FilePath_Text { get; set; }
        public DateTime? Version_CreatedOn_Date { get; set; }
        public string Version_CreatedBy_User_Name { get; set; }
        public string VersionNotes_Text { get; set; }
    }
}
