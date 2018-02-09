using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ConfigurationFileExtended
    {
        public int ConfigurationFile_Id { get; set; }
        public int? Deployable_Id { get; set; }
        public string FilePath_Text { get; set; }
        public string ConfigurationFile_Name { get; set; }
        public string Description_Text { get; set; }
        public int Application_Id { get; set; }
        public bool Active_Indicator { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public DateTime? ModifiedOn_Date { get; set; }
        public string Deployable_Name { get; set; }
        public int? LatestDeployment_ConfigurationFileDeployment_Id { get; set; }
        public int? LatestDeployment_Execution_Id { get; set; }
        public string LatestDeployment_Instance_Name { get; set; }
        public int? LatestDeployment_Version_Number { get; set; }
        public int? LatestDeployment_Server_Id { get; set; }
        public string LatestDeployment_DeployedTo_Path { get; set; }
        public string LatestDeployment_DeployedBy_User_Name { get; set; }
        public DateTime? LatestDeployment_DeployedOn_Date { get; set; }
        public string LatestDeployment_Server_Name { get; set; }
        public string LatestVersion_Instance_Name { get; set; }
        public int? LatestVersion_Version_Number { get; set; }
        public string LatestVersion_VersionNotes_Text { get; set; }
        public DateTime? LatestVersion_File_Date { get; set; }
        public string LatestVersionCreatedBy_User_Name { get; set; }
        public DateTime? LatestVersionCreatedOn_Date { get; set; }
    }
}
