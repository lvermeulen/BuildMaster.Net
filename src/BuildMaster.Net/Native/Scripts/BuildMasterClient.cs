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
        /// Creates a new script parameter or updates an existing one
        /// </summary>
        public async Task<bool> Scripts_CreateOrUpdateParameterAsync(
            int script_Id,
            string parameter_Name,
            string parameterType_Code,
            string defaultValue_Text,
            string description_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(script_Id).Capitalize(), script_Id),
                new NamedValue(nameof(parameter_Name).Capitalize(), parameter_Name),
                new NamedValue(nameof(parameterType_Code).Capitalize(), parameterType_Code),
                new NamedValue(nameof(defaultValue_Text).Capitalize(), defaultValue_Text),
                new NamedValue(nameof(description_Text).Capitalize(), description_Text)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Scripts_CreateOrUpdateParameterAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a new script or updates an existing one
        /// </summary>
        /// <returns>Script_Id</returns>
        public async Task<int> Scripts_CreateOrUpdateScriptAsync(
            int script_Id,
            string script_Name,
            string description_Text,
            string scriptType_Code,
            bool active_Indicator,
            bool autoSync_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(script_Id).Capitalize(), script_Id),
                new NamedValue(nameof(script_Name).Capitalize(), script_Name),
                new NamedValue(nameof(description_Text).Capitalize(), description_Text),
                new NamedValue(nameof(scriptType_Code).Capitalize(), scriptType_Code),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(autoSync_Indicator).Capitalize(), autoSync_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Scripts_CreateOrUpdateScriptAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a new script variable or updates an existing one
        /// </summary>
        public async Task<bool> Scripts_CreateOrUpdateVariableAsync(
            int script_Id,
            string scriptVariable_Name,
            string value_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(script_Id).Capitalize(), script_Id),
                new NamedValue(nameof(scriptVariable_Name).Capitalize(), scriptVariable_Name),
                new NamedValue(nameof(value_Text).Capitalize(), value_Text)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Scripts_CreateOrUpdateVariableAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a new version of a script
        /// </summary>
        /// <returns>Version_Number</returns>
        public async Task<int> Scripts_CreateVersionAsync(
            int version_Number,
            int script_Id,
            byte[] script_Bytes)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(version_Number).Capitalize(), version_Number),
                new NamedValue(nameof(script_Id).Capitalize(), script_Id),
                new NamedValue(nameof(script_Bytes).Capitalize(), script_Bytes)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Scripts_CreateVersionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a script parameter
        /// </summary>
        public async Task<bool> Scripts_DeleteParameterAsync(
            int script_Id,
            string parameter_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(script_Id).Capitalize(), script_Id),
                new NamedValue(nameof(parameter_Name).Capitalize(), parameter_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Scripts_DeleteParameterAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Permanently deletes a script
        /// </summary>
        public async Task<bool> Scripts_DeleteScriptAsync(int script_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(script_Id).Capitalize(), script_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Scripts_DeleteScriptAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a script variable
        /// </summary>
        public async Task<bool> Scripts_DeleteVariableAsync(
            int script_Id,
            string scriptVariable_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(script_Id).Capitalize(), script_Id),
                new NamedValue(nameof(scriptVariable_Name).Capitalize(), scriptVariable_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Scripts_DeleteVariableAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a script and all of its associated information
        /// </summary>
        public async Task<ScriptsExtendedScriptParametersScriptVariables> Scripts_GetScriptAsync(int script_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(script_Id).Capitalize(), script_Id)
            );

            return await ExecuteNativeApiMethodAsync<ScriptsExtendedScriptParametersScriptVariables>(nameof(Scripts_GetScriptAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all of the scripts in the system, optionally filtered by type code
        /// </summary>
        public async Task<IEnumerable<ScriptExtended>> Scripts_GetScriptsAsync(
            string scriptType_Code = null,
            bool? includeInactive_Indicator = true)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(scriptType_Code).Capitalize(), scriptType_Code),
                new NamedValue(nameof(includeInactive_Indicator).Capitalize(), includeInactive_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ScriptExtended>>(nameof(Scripts_GetScriptsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
