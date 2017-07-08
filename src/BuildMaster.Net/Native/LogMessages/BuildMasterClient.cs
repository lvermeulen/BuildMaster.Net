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
        /// Deletes one or all message from the error log
        /// </summary>
        public async Task<bool> LogMessages_DeleteMessagesAsync(int? logMessage_Id = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(logMessage_Id).Capitalize(), logMessage_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(LogMessages_DeleteMessagesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a specified message from the error log
        /// </summary>
        public async Task<LogMessageExtended> LogMessages_GetMessageAsync(int logMessage_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(logMessage_Id).Capitalize(), logMessage_Id)
            );

            return await ExecuteNativeApiMethodAsync<LogMessageExtended>(nameof(LogMessages_GetMessageAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the messages from the error log that match the specified criteria
        /// </summary>
        public async Task<IEnumerable<LogMessageExtended>> LogMessages_GetMessagesAsync(
            int? row_Count = null,
            int? message_Level = null,
            string category_Name = null,
            int? application_Id = null,
            int? schedule_Id = null,
            int? requirement_Id = null,
            int? provider_Id = null,
            int? eventListener_Id = null,
            int? server_Id = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(row_Count).Capitalize(), row_Count),
                new NamedValue(nameof(message_Level).Capitalize(), message_Level),
                new NamedValue(nameof(category_Name).Capitalize(), category_Name),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(schedule_Id).Capitalize(), schedule_Id),
                new NamedValue(nameof(requirement_Id).Capitalize(), requirement_Id),
                new NamedValue(nameof(provider_Id).Capitalize(), provider_Id),
                new NamedValue(nameof(eventListener_Id).Capitalize(), eventListener_Id),
                new NamedValue(nameof(server_Id).Capitalize(), server_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<LogMessageExtended>>(nameof(LogMessages_GetMessagesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
