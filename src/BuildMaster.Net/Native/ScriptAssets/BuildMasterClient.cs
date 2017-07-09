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
        /// Creates a new script or updates an existing one
        /// </summary>
        /// <returns>ScriptAsset_Id</returns>
        public async Task<int> ScriptAssets_CreateOrUpdateScriptAsync(
            string scriptAsset_Name,
            int application_Id,
            byte[] script_Text,
            int scriptAsset_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(scriptAsset_Name).Capitalize(), scriptAsset_Name),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(script_Text).Capitalize(), script_Text),
                new NamedValue(nameof(scriptAsset_Id).Capitalize(), scriptAsset_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(ScriptAssets_CreateOrUpdateScriptAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a script
        /// </summary>
        public async Task<bool> ScriptAssets_DeleteScriptAsync(int scriptAsset_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(scriptAsset_Id).Capitalize(), scriptAsset_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(ScriptAssets_DeleteScriptAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the script with the specified ID
        /// </summary>
        public async Task<ScriptAsset> ScriptAssets_GetScriptAsync(int scriptAsset_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(scriptAsset_Id).Capitalize(), scriptAsset_Id)
            );

            return await ExecuteNativeApiMethodAsync<ScriptAsset>(nameof(ScriptAssets_GetScriptAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the script with the specified name, searching from the specified application
        /// </summary>
        public async Task<ScriptAsset> ScriptAssets_GetScriptByNameAsync(
            string scriptAsset_Name,
            int application_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(scriptAsset_Name).Capitalize(), scriptAsset_Name),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync<ScriptAsset>(nameof(ScriptAssets_GetScriptByNameAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the scripts which are visible to the specified application
        /// </summary>
        public async Task<IEnumerable<ScriptAsset>> ScriptAssets_GetScriptsAsync(int application_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ScriptAsset>>(nameof(ScriptAssets_GetScriptsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
