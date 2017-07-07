using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class EventOccurrencesExtendedEventOccurrenceDetails
    {
        public List<EventOccurrenceExtended> EventOccurences_Extended { get; set; }
        public List<EventOccurrenceDetails> EventOccurenceDetails { get; set; }

    }
}
