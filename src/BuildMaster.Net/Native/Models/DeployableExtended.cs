using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class DeployableExtended
    {
        public int Deployable_Id { get; set; }
        public string Deployable_Name { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public DateTime? ModifiedOn_Date { get; set; }
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int? Dependencies_Count { get; set; }
        public int? Dependants_Count { get; set; }
    }
}
