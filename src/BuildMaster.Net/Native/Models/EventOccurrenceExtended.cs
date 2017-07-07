// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class EventOccurrenceExtended
    {
        public int EventOccurence_Id { get; set; }
        public string Event_Code { get; set; }
        public string User_Name { get; set; }
        public string Occurence_Date { get; set; }
        public int? Application_Id { get; set; }
        public string Event_Description { get; set; }
        public string Application_Name { get; set; }
        public object ApplicationGroup_Id { get; set; }
    }
}
