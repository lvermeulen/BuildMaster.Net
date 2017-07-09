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
        /// Gets the complete list of BuildMaster configuration settings
        /// </summary>
        public async Task<IEnumerable<Configuration>> Configuration_GetConfigurationAsync() => 
            await ExecuteNativeApiMethodAsync<IEnumerable<Configuration>>(nameof(Configuration_GetConfigurationAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

        /// <summary>
        /// Gets the specified BuildMaster configuration value
        /// </summary>
        /// <returns>Value_Text</returns>
        public async Task<string> Configuration_GetValueAsync(
            string scope_Name,
            string Key_Name,
            string value_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(scope_Name).Capitalize(), scope_Name),
                new NamedValue(nameof(Key_Name).Capitalize(), Key_Name),
                new NamedValue(nameof(value_Text).Capitalize(), value_Text)
            );

            return await ExecuteNativeApiMethodAsync<string>(nameof(Configuration_GetValueAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Sets a BuildMaster configuration value
        /// </summary>
        public async Task<bool> Configuration_SetValueAsync(
            string scope_Name,
            string Key_Name,
            string value_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(scope_Name).Capitalize(), scope_Name),
                new NamedValue(nameof(Key_Name).Capitalize(), Key_Name),
                new NamedValue(nameof(value_Text).Capitalize(), value_Text)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Configuration_SetValueAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
