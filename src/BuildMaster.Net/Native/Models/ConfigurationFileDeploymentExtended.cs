using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ConfigurationFileDeploymentExtended
    {
        public int ConfigurationFileDeployment_Id { get; set; }
        public int? Execution_Id { get; set; }
        public int ConfigurationFile_Id { get; set; }
        public string ConfigurationFile_Name { get; set; }
        public string FilePath_Text { get; set; }
        public string Instance_Name { get; set; }
        public int Version_Number { get; set; }
        public int? Server_Id { get; set; }
        public string DeployedTo_Path { get; set; }
        public string DeployedBy_User_Name { get; set; }
        public DateTime? DeployedOn_Date { get; set; }
        public int? Environment_Id { get; set; }
        public string Environment_Name { get; set; }
        public int? Deployable_Id { get; set; }
        public bool ConfigurationFile_Active_Indicator { get; set; }
        public string Deployable_Name { get; set; }
        public int? Application_Id { get; set; }
        public string Server_Name { get; set; }
        public int? Release_Id { get; set; }
        public string Release_Number { get; set; }
        public string Release_Name { get; set; }
        public int? Build_Id { get; set; }
        public string Build_Number { get; set; }
        public int? Promotion_Id { get; set; }
        public string PipelineStage_Name { get; set; }
    }
}
