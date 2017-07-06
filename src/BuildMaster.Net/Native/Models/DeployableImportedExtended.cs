using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class DeployableImportedExtended
    {
        public int Deployable_Id { get; set; }
        public string Deployable_Name { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public DateTime? ModifiedOn_Date { get; set; }
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int ImportedFrom_Application_Id { get; set; }
        public string ImportedFrom_Application_Name { get; set; }
    }
}
