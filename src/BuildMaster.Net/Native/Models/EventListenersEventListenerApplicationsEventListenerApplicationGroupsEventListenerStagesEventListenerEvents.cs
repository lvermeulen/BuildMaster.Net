using System.Collections.Generic;

namespace BuildMaster.Net.Native.Models
{
    public class EventListenersEventListenerApplicationsEventListenerApplicationGroupsEventListenerStagesEventListenerEvents
    {
        public List<EventListener> EventListeners { get; set; }
        public List<EventListenerApplication> EventListenerApplications { get; set; }
        public List<EventListenerApplicationGroup> EventListenerApplicationGroups { get; set; }
        public List<EventListenerStage> EventListenerStages { get; set; }
        public List<EventListenerEvent> EventListenerEvents { get; set; }
    }
}
