using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ApplicationGroup
    {
        public int ApplicationGroup_Id { get; set; }
        public string ApplicationGroup_Name { get; set; }
        public string ApplicationGroup_Description { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public DateTime? ModifiedOn_Date { get; set; }
        public int? Parent_ApplicationGroup_Id { get; set; }
    }
}
