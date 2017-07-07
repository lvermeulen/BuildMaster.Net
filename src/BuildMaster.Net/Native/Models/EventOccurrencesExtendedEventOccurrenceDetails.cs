using System.Collections.Generic;

namespace BuildMaster.Net.Native.Models
{
    public class EventOccurrencesExtendedEventOccurrenceDetails
    {
        public List<EventOccurrenceExtended> EventOccurences_Extended { get; set; }
        public List<object> EventOccurenceDetails { get; set; }
    }
}
