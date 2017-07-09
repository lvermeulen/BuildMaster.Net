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
        /// Deletes an extension configuration
        /// </summary>
        public async Task<bool> ExtensionConfiguration_DeleteConfigurationAsync(int extensionConfiguration_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(extensionConfiguration_Id).Capitalize(), extensionConfiguration_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(ExtensionConfiguration_DeleteConfigurationAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of an extension configurer for extension with the specified name
        /// </summary>
        public async Task<IEnumerable<ExtensionConfiguration>> ExtensionConfiguration_GetConfigurationAsync(
            string qualifiedType_Name,
            string profile_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(qualifiedType_Name).Capitalize(), qualifiedType_Name),
                new NamedValue(nameof(profile_Name).Capitalize(), profile_Name)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ExtensionConfiguration>>(nameof(ExtensionConfiguration_GetConfigurationAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of an extension configurer for extension with the specified ID
        /// </summary>
        public async Task<ExtensionConfiguration> ExtensionConfiguration_GetConfigurationByIdAsync(int extensionConfiguration_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(extensionConfiguration_Id).Capitalize(), extensionConfiguration_Id)
            );

            return await ExecuteNativeApiMethodAsync<ExtensionConfiguration>(nameof(ExtensionConfiguration_GetConfigurationByIdAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details for all extension configurers in the system, or a specific one if specified
        /// </summary>
        public async Task<IEnumerable<ExtensionConfiguration>> ExtensionConfiguration_GetConfigurationsAsync(string qualifiedType_Name = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(qualifiedType_Name).Capitalize(), qualifiedType_Name)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ExtensionConfiguration>>(nameof(ExtensionConfiguration_GetConfigurationsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates an extension configurer in the system, or updates an existing one
        /// </summary>
        /// <returns>ExtensionConfiguration_Id</returns>
        public async Task<int> ExtensionConfiguration_SaveConfigurationAsync(
            int extensionConfiguration_Id,
            string qualifiedType_Name,
            string profile_Name,
            string extension_Configuration,
            bool default_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(extensionConfiguration_Id).Capitalize(), extensionConfiguration_Id),
                new NamedValue(nameof(qualifiedType_Name).Capitalize(), qualifiedType_Name),
                new NamedValue(nameof(profile_Name).Capitalize(), profile_Name),
                new NamedValue(nameof(extension_Configuration).Capitalize(), extension_Configuration),
                new NamedValue(nameof(default_Indicator).Capitalize(), default_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(ExtensionConfiguration_SaveConfigurationAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
