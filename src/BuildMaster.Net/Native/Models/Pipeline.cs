using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class Pipeline
    {
        public int Pipeline_Id { get; set; }
        public string Pipeline_Name { get; set; }
        public string Pipeline_Configuration { get; set; }
        public bool Active_Indicator { get; set; }
        public int Application_Id { get; set; }
        public DateTime? ModifiedOn_Date { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public int? MigratedFrom_Workflow_Id { get; set; }
        public string Pipeline_Color { get; set; }
    }
}
