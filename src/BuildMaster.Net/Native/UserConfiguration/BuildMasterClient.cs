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
        /// Gets the complete list of user configuration settings
        /// </summary>
        public async Task<IEnumerable<UserConfiguration>> UserConfiguration_GetUserConfigurationAsync(string user_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(user_Name).Capitalize(), user_Name)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<UserConfiguration>>(nameof(UserConfiguration_GetUserConfigurationAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified user configuration value
        /// </summary>
        /// <returns>Value_Text</returns>
        public async Task<string> UserConfiguration_GetValueAsync(
            string user_Name,
            string key_Name,
            string value_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(user_Name).Capitalize(), user_Name),
                new NamedValue(nameof(key_Name).Capitalize(), key_Name),
                new NamedValue(nameof(value_Text).Capitalize(), value_Text)
            );

            return await ExecuteNativeApiMethodAsync<string>(nameof(UserConfiguration_GetValueAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Sets a user configuration value
        /// </summary>
        public async Task<bool> UserConfiguration_SetValueAsync(
            string user_Name,
            string key_Name,
            string value_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(user_Name).Capitalize(), user_Name),
                new NamedValue(nameof(key_Name).Capitalize(), key_Name),
                new NamedValue(nameof(value_Text).Capitalize(), value_Text)
            );

            return await ExecuteNativeApiMethodAsync(nameof(UserConfiguration_SetValueAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
