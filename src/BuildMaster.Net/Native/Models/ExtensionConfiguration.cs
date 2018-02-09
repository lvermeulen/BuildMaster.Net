using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ExtensionConfiguration
    {
        public int ExtensionConfiguration_Id { get; set; }
        public string QualifiedType_Name { get; set; }
        public string Profile_Name { get; set; }
        public string Extension_Configuration { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public DateTime? ModifiedOn_Date { get; set; }
        public bool Default_Indicator { get; set; }
    }
}
