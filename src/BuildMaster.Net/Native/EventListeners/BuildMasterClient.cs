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
        /// Creates or updates an event listener
        /// </summary>
        /// <returns>EventListener_Id</returns>
        public async Task<int> EventListeners_CreateOrUpdateEventListenerAsync(
            string eventListener_Description,
            string eventListener_Configuration,
            string owner_User_Name,
            bool active_Indicator,
            string eventCodeList_Csv,
            string applicationIdList_Csv,
            string applicationGroupIdList_Csv,
            string pipelineStageNameList_Csv,
            int eventListener_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(eventListener_Description).Capitalize(), eventListener_Description),
                new NamedValue(nameof(eventListener_Configuration).Capitalize(), eventListener_Configuration),
                new NamedValue(nameof(owner_User_Name).Capitalize(), owner_User_Name),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(eventCodeList_Csv).Capitalize(), eventCodeList_Csv),
                new NamedValue(nameof(applicationIdList_Csv).Capitalize(), applicationIdList_Csv),
                new NamedValue(nameof(applicationGroupIdList_Csv).Capitalize(), applicationGroupIdList_Csv),
                new NamedValue(nameof(pipelineStageNameList_Csv).Capitalize(), pipelineStageNameList_Csv),
                new NamedValue(nameof(eventListener_Id).Capitalize(), eventListener_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(EventListeners_CreateOrUpdateEventListenerAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes an event listener
        /// </summary>
        public async Task<bool> EventListeners_DeleteEventListenerAsync(int eventListener_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(eventListener_Id).Capitalize(), eventListener_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(EventListeners_DeleteEventListenerAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a EventListener and a list of event codes that the EventListener is subscribed to
        /// </summary>
        public async Task<EventListenersEventListenerApplicationsEventListenerApplicationGroupsEventListenerStagesEventListenerEvents> EventListeners_GetEventListenerAsync(int eventListener_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(eventListener_Id).Capitalize(), eventListener_Id)
            );

            return await ExecuteNativeApiMethodAsync<EventListenersEventListenerApplicationsEventListenerApplicationGroupsEventListenerStagesEventListenerEvents>(nameof(EventListeners_GetEventListenerAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of event listeners for the specified user, or all users if no user is specified
        /// </summary>
        public async Task<EventListenersEventListenerApplicationsEventListenerApplicationGroupsEventListenerStagesEventListenerEvents> EventListeners_GetEventListenersAsync(string owner_User_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(owner_User_Name).Capitalize(), owner_User_Name)
            );

            return await ExecuteNativeApiMethodAsync<EventListenersEventListenerApplicationsEventListenerApplicationGroupsEventListenerStagesEventListenerEvents>(nameof(EventListeners_GetEventListenersAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
