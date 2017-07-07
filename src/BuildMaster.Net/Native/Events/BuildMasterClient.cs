using System.Collections.Generic;
using System.Threading.Tasks;
using BuildMaster.Net.Common;
using BuildMaster.Net.Native.Models;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        /// <summary>
        /// Get a specific event occurrence along with its event details
        /// </summary>
        public async Task<EventOccurrencesExtendedEventOccurrenceDetails> Events_GetEventOccurrenceAsync(int eventOccurence_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(eventOccurence_Id).Capitalize(), eventOccurence_Id)
            );

            return await ExecuteNativeApiMethodAsync<EventOccurrencesExtendedEventOccurrenceDetails>(nameof(Events_GetEventOccurrenceAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all the event occurrences in the system for a specific application, or all applications, limited to a specified count if provided
        /// </summary>
        public async Task<IEnumerable<EventOccurrenceExtended>> Events_GetEventOccurrencesAsync(
            int? application_Id = null,
            int? event_Count = null,
            int? after_EventOccurence_Id = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(event_Count).Capitalize(), event_Count),
                new NamedValue(nameof(after_EventOccurence_Id).Capitalize(), after_EventOccurence_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<EventOccurrenceExtended>>(nameof(Events_GetEventOccurrencesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
