using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ActionGroup
    {
        public int ActionGroup_Id { get; set; }
        public string CreatedBy_User_Name { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public DateTime? ModifiedOn_Date { get; set; }
        public string ActionGroup_Name { get; set; }
        public string Predicate_Configuration { get; set; }
        public string ActionGroup_Description { get; set; }
        public int? Server_Id { get; set; }
        public string Server_Variable_Name { get; set; }
    }
}
