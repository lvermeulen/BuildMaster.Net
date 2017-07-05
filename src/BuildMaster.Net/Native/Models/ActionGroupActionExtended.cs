using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ActionGroupActionExtended
    {
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int Release_Id { get; set; }
        public string Release_Number { get; set; }
        public int Build_Id { get; set; }
        public string Build_Number { get; set; }
        public int? Deployable_Id { get; set; }
        public string Deployable_Name { get; set; }
        public string Artifact_Name { get; set; }
        public int? Execution_Id { get; set; }
        public DateTime Created_Date { get; set; }
        public string Artifact_Path { get; set; }
    }
}
