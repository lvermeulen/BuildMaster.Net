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
        /// Creates a configuration file in the system
        /// </summary>
        /// <returns>ConfigurationFile_Id</returns>
        public async Task<int> ConfigurationFiles_CreateConfigurationFileAsync(
            int application_Id,
            int deployable_Id,
            string filePath_Text,
            string configurationFile_Name,
            string description_Text,
            int configurationFile_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id),
                new NamedValue(nameof(filePath_Text).Capitalize(), filePath_Text),
                new NamedValue(nameof(configurationFile_Name).Capitalize(), configurationFile_Name),
                new NamedValue(nameof(description_Text).Capitalize(), description_Text),
                new NamedValue(nameof(configurationFile_Id).Capitalize(), configurationFile_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(ConfigurationFiles_CreateConfigurationFileAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a new instance of a configuration file
        /// </summary>
        public async Task<bool> ConfigurationFiles_CreateConfigurationFileInstanceAsync(
            int configurationFile_Id,
            string instance_Name,
            int environment_Id,
            bool template_Indicator,
            string template_Instance_Name,
            string transformType_Code)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(configurationFile_Id).Capitalize(), configurationFile_Id),
                new NamedValue(nameof(instance_Name).Capitalize(), instance_Name),
                new NamedValue(nameof(environment_Id).Capitalize(), environment_Id),
                new NamedValue(nameof(template_Indicator).Capitalize(), template_Indicator.ToYnIndicator()),
                new NamedValue(nameof(template_Instance_Name).Capitalize(), template_Instance_Name),
                new NamedValue(nameof(transformType_Code).Capitalize(), transformType_Code)
            );

            return await ExecuteNativeApiMethodAsync(nameof(ConfigurationFiles_CreateConfigurationFileInstanceAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates new configuration file versions for each instance specified in the ConfigurationFiles_Xml for the given configuration file
        /// </summary>
        public async Task<bool> ConfigurationFiles_CreateConfigurationFileVersionsAsync(
            int configurationFile_Id,
            string configurationFiles_Xml,
            string releaseNumbers_Csv)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(configurationFile_Id).Capitalize(), configurationFile_Id),
                new NamedValue(nameof(configurationFiles_Xml).Capitalize(), configurationFiles_Xml),
                new NamedValue(nameof(releaseNumbers_Csv).Capitalize(), releaseNumbers_Csv)
            );

            return await ExecuteNativeApiMethodAsync(nameof(ConfigurationFiles_CreateConfigurationFileVersionsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Saves the result of a deployed configuration file(this will not physically deploy the configuration file)
        /// </summary>
        /// <returns>ConfigurationFileDeployment_Id</returns>
        public async Task<int> ConfigurationFiles_DeployConfigurationFileAsync(
            int execution_Id,
            int configurationFile_Id,
            string instance_Name,
            int version_Number,
            int server_Id,
            string deployedTo_Path,
            string deployedBy_User_Name,
            int configurationFileDeployment_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id),
                new NamedValue(nameof(configurationFile_Id).Capitalize(), configurationFile_Id),
                new NamedValue(nameof(instance_Name).Capitalize(), instance_Name),
                new NamedValue(nameof(version_Number).Capitalize(), version_Number),
                new NamedValue(nameof(server_Id).Capitalize(), server_Id),
                new NamedValue(nameof(deployedTo_Path).Capitalize(), deployedTo_Path),
                new NamedValue(nameof(deployedBy_User_Name).Capitalize(), deployedBy_User_Name),
                new NamedValue(nameof(configurationFileDeployment_Id).Capitalize(), configurationFileDeployment_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(ConfigurationFiles_DeployConfigurationFileAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a configuration file and all of its instances
        /// </summary>
        public async Task<ConfigurationFilesExtendedConfigurationFileInstancesExtendedConfigurationFileVersionsCombinedConfigurationFileVersionsModifiedInstances> ConfigurationFiles_GetConfigurationFileAsync(
            int configurationFile_Id,
            bool includeInactiveInstances_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(configurationFile_Id).Capitalize(), configurationFile_Id),
                new NamedValue(nameof(includeInactiveInstances_Indicator).Capitalize(), includeInactiveInstances_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<ConfigurationFilesExtendedConfigurationFileInstancesExtendedConfigurationFileVersionsCombinedConfigurationFileVersionsModifiedInstances>(nameof(ConfigurationFiles_GetConfigurationFileAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of all configuration file deployments based on the specified criteria
        /// </summary>
        public async Task<IEnumerable<ConfigurationFileDeploymentExtended>> ConfigurationFiles_GetConfigurationFileDeploymentsAsync(
            int application_Id,
            int configurationFile_Id,
            int deployable_Id,
            string instance_Name,
            int server_Id,
            int file_Count)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(configurationFile_Id).Capitalize(), configurationFile_Id),
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id),
                new NamedValue(nameof(instance_Name).Capitalize(), instance_Name),
                new NamedValue(nameof(server_Id).Capitalize(), server_Id),
                new NamedValue(nameof(file_Count).Capitalize(), file_Count)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ConfigurationFileDeploymentExtended>>(nameof(ConfigurationFiles_GetConfigurationFileDeploymentsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of all configuration file instances that match the specified criteria
        /// </summary>
        public async Task<IEnumerable<ConfigurationFileInstanceExtended>> ConfigurationFiles_GetConfigurationFileInstancesAsync(
            int application_Id,
            int deployable_Id,
            bool active_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ConfigurationFileInstanceExtended>>(nameof(ConfigurationFiles_GetConfigurationFileInstancesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all configuration files that match the specified criteria
        /// </summary>
        public async Task<ConfigurationFilesExtendedConfigurationFileInstancesExtendedConfigurationFileVersionsCombinedConfigurationFileVersionsModifiedInstances> ConfigurationFiles_GetConfigurationFilesAsync(
            int application_Id,
            int deployable_Id,
            bool includeInactive_Indicator,
            bool includeInstances_Indicator,
            bool includeVersions_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id),
                new NamedValue(nameof(includeInactive_Indicator).Capitalize(), includeInactive_Indicator.ToYnIndicator()),
                new NamedValue(nameof(includeInstances_Indicator).Capitalize(), includeInstances_Indicator.ToYnIndicator()),
                new NamedValue(nameof(includeVersions_Indicator).Capitalize(), includeVersions_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<ConfigurationFilesExtendedConfigurationFileInstancesExtendedConfigurationFileVersionsCombinedConfigurationFileVersionsModifiedInstances>(nameof(ConfigurationFiles_GetConfigurationFilesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of configuration file versions for a specified configuration file
        /// </summary>
        public async Task<IEnumerable<ConfigurationFileVersionExtended>> ConfigurationFiles_GetConfigurationFileVersionAsync(
            int configurationFile_Id,
            string instance_Name,
            int version_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(configurationFile_Id).Capitalize(), configurationFile_Id),
                new NamedValue(nameof(instance_Name).Capitalize(), instance_Name),
                new NamedValue(nameof(version_Number).Capitalize(), version_Number)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ConfigurationFileVersionExtended>>(nameof(ConfigurationFiles_GetConfigurationFileVersionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Purges a configuration file, including all previous versions of all instances and deployment history
        /// </summary>
        public async Task<bool> ConfigurationFiles_PurgeConfigurationFileAsync(int configurationFile_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(configurationFile_Id).Capitalize(), configurationFile_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(ConfigurationFiles_PurgeConfigurationFileAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Purges a configuration file instance, including all previous versions and deployment history
        /// </summary>
        public async Task<bool> ConfigurationFiles_PurgeConfigurationFileInstanceAsync(
            int configurationFile_Id,
            string instance_Name,
            bool unlinkTemplate_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(configurationFile_Id).Capitalize(), configurationFile_Id),
                new NamedValue(nameof(instance_Name).Capitalize(), instance_Name),
                new NamedValue(nameof(unlinkTemplate_Indicator).Capitalize(), unlinkTemplate_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync(nameof(ConfigurationFiles_PurgeConfigurationFileInstanceAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates metadata for an existing configuration file
        /// </summary>
        public async Task<bool> ConfigurationFiles_UpdateConfigurationFileAsync(
            int configurationFile_Id,
            bool active_Indicator,
            string configurationFile_Name,
            string filePath_Text,
            string description_Text,
            int deployable_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(configurationFile_Id).Capitalize(), configurationFile_Id),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(configurationFile_Name).Capitalize(), configurationFile_Name),
                new NamedValue(nameof(filePath_Text).Capitalize(), filePath_Text),
                new NamedValue(nameof(description_Text).Capitalize(), description_Text),
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(ConfigurationFiles_UpdateConfigurationFileAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates metadata for an existing configuration file instance
        /// </summary>
        public async Task<bool> ConfigurationFiles_UpdateConfigurationFileInstanceAsync(
            int configurationFile_Id,
            string instance_Name,
            int environment_Id,
            bool active_Indicator,
            string template_Instance_Name,
            string transformType_Code)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(configurationFile_Id).Capitalize(), configurationFile_Id),
                new NamedValue(nameof(instance_Name).Capitalize(), instance_Name),
                new NamedValue(nameof(environment_Id).Capitalize(), environment_Id),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(template_Instance_Name).Capitalize(), template_Instance_Name),
                new NamedValue(nameof(transformType_Code).Capitalize(), transformType_Code)
            );

            return await ExecuteNativeApiMethodAsync(nameof(ConfigurationFiles_UpdateConfigurationFileInstanceAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
