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
        /// Creates or updates a new application group
        /// </summary>
        /// <returns>ApplicationGroup_Id</returns>
        public async Task<int> ApplicationGroups_CreateOrUpdateApplicationGroupAsync(
            int applicationGroup_Id,
            string applicationGroup_Name,
            string applicationGroup_Description,
            int parent_ApplicationGroup_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(applicationGroup_Id).Capitalize(), applicationGroup_Id),
                new NamedValue(nameof(applicationGroup_Name).Capitalize(), applicationGroup_Name),
                new NamedValue(nameof(applicationGroup_Description).Capitalize(), applicationGroup_Description),
                new NamedValue(nameof(parent_ApplicationGroup_Id).Capitalize(), parent_ApplicationGroup_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(ApplicationGroups_CreateOrUpdateApplicationGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes an application group
        /// </summary>
        public async Task<bool> ApplicationGroups_DeleteApplicationGroupAsync(int applicationGroup_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(applicationGroup_Id).Capitalize(), applicationGroup_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(ApplicationGroups_DeleteApplicationGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an application group by ID
        /// </summary>
        public async Task<ApplicationGroup> ApplicationGroups_GetApplicationGroupAsync(int applicationGroup_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(applicationGroup_Id).Capitalize(), applicationGroup_Id)
            );

            return await ExecuteNativeApiMethodAsync<ApplicationGroup>(nameof(ApplicationGroups_GetApplicationGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all the application groups
        /// </summary>
        public async Task<IEnumerable<ApplicationGroup>> ApplicationGroups_GetApplicationGroupsAsync() => 
            await ExecuteNativeApiMethodAsync<IEnumerable<ApplicationGroup>>(nameof(ApplicationGroups_GetApplicationGroupsAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

        /// <summary>
        /// Gets or creates a new application group using the name
        /// </summary>
        /// <returns>ApplicationGroup_Id</returns>
        public async Task<int> ApplicationGroups_GetOrCreateApplicationGroupAsync(
            string applicationGroup_Name,
            int applicationGroup_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(applicationGroup_Name).Capitalize(), applicationGroup_Name),
                new NamedValue(nameof(applicationGroup_Id).Capitalize(), applicationGroup_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(ApplicationGroups_GetOrCreateApplicationGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
