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
        /// Creates or edits a database change script
        /// </summary>
        /// <returns>Script_Id</returns>
        public async Task<int> DatabaseChangeScripts_CreateOrUpdateChangeScriptAsync(
            int application_Id,
            string release_Number,
            int deployable_Id,
            string script_Name,
            string script_Text,
            bool active_Indicator,
            int script_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id),
                new NamedValue(nameof(script_Name).Capitalize(), script_Name),
                new NamedValue(nameof(script_Text).Capitalize(), script_Text),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(script_Id).Capitalize(), script_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(DatabaseChangeScripts_CreateOrUpdateChangeScriptAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a database change script
        /// </summary>
        public async Task<bool> DatabaseChangeScripts_DeleteChangeScriptAsync(int script_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(script_Id).Capitalize(), script_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(DatabaseChangeScripts_DeleteChangeScriptAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified database change script
        /// </summary>
        public async Task<DatabaseChangeScriptExtended> DatabaseChangeScripts_GetChangeScriptAsync(int script_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(script_Id).Capitalize(), script_Id)
            );

            return await ExecuteNativeApiMethodAsync<DatabaseChangeScriptExtended>(nameof(DatabaseChangeScripts_GetChangeScriptAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all the database change scripts that match the specified criteria
        /// </summary>
        public async Task<IEnumerable<DatabaseChangeScriptExtended>> DatabaseChangeScripts_GetChangeScriptsAsync(
            int application_Id,
            string release_Number,
            bool includeInactive_Indicator,
            int databaseChangeScript_Count)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(includeInactive_Indicator).Capitalize(), includeInactive_Indicator.ToYnIndicator()),
                new NamedValue(nameof(databaseChangeScript_Count).Capitalize(), databaseChangeScript_Count)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<DatabaseChangeScriptExtended>>(nameof(DatabaseChangeScripts_GetChangeScriptsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a database change script execution
        /// </summary>
        public async Task<DatabaseChangeScriptExecutionExtended> DatabaseChangeScripts_GetExecutionAsync(int execution_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id)
            );

            return await ExecuteNativeApiMethodAsync<DatabaseChangeScriptExecutionExtended>(nameof(DatabaseChangeScripts_GetExecutionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
