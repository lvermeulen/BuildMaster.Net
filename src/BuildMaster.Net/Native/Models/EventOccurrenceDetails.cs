// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class EventOccurrenceDetails
    {
        public int EventOccurence_Id { get; set; }
        public string Event_Code { get; set; }
        public string Detail_Name { get; set; }
        public object Detail_Value { get; set; }
    }
}
