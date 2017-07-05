using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildPromotionsScheduledExtended
    {
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int Release_Id { get; set; }
        public string Release_Number { get; set; }
        public string Release_Name { get; set; }
        public int Build_Id { get; set; }
        public string Build_Number { get; set; }
        public string PipelineStage_Name { get; set; }
        public DateTime PromoteOn_Date { get; set; }
    }
}
