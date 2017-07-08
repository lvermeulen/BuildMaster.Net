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
        /// Creates a new notifier, or updates an existing one
        /// </summary>
        public async Task<bool> Notifiers_CreateOrUpdateNotifierAsync(
            int notifier_Id,
            string notifier_Name,
            string notifier_Description,
            string notifier_Configuration,
            string owner_User_Name,
            bool active_Indicator,
            string eventCodeList_Csv)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(notifier_Id).Capitalize(), notifier_Id),
                new NamedValue(nameof(notifier_Name).Capitalize(), notifier_Name),
                new NamedValue(nameof(notifier_Description).Capitalize(), notifier_Description),
                new NamedValue(nameof(notifier_Configuration).Capitalize(), notifier_Configuration),
                new NamedValue(nameof(owner_User_Name).Capitalize(), owner_User_Name),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(eventCodeList_Csv).Capitalize(), eventCodeList_Csv)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Notifiers_CreateOrUpdateNotifierAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a notifier from the system
        /// </summary>
        public async Task<bool> Notifiers_DeleteNotifierAsync(int notifier_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(notifier_Id).Capitalize(), notifier_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Notifiers_DeleteNotifierAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a notifier and a list of event codes that the notifier is subscribed to
        /// </summary>
        public async Task<NotifiersNotifierEventCodes> Notifiers_GetNotifierAsync(int notifier_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(notifier_Id).Capitalize(), notifier_Id)
            );

            return await ExecuteNativeApiMethodAsync<NotifiersNotifierEventCodes>(nameof(Notifiers_GetNotifierAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of notifiers for the specified user, or all users if no user is specified
        /// </summary>
        public async Task<IEnumerable<Notifier>> Notifiers_GetNotifiersAsync(string owner_User_Name = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(owner_User_Name).Capitalize(), owner_User_Name)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<Notifier>>(nameof(Notifiers_GetNotifiersAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
