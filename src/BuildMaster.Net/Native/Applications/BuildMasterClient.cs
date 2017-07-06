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
        /// Adds an imported deployable to an application
        /// </summary>
        public async Task<bool> Applications_AddImportedDeployableAsync(
            int deployable_Id,
            int application_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Applications_AddImportedDeployableAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a new application
        /// </summary>
        /// <returns>Application_Id</returns>
        public async Task<int> Applications_CreateApplicationAsync(
            string application_Name,
            string releaseNumber_Scheme_Name,
            int issueTracking_Provider_Id,
            string buildNumber_Scheme_Name,
            bool allowMultipleActiveReleases_Indicator,
            bool allowMultipleActiveBuilds_Indicator,
            int applicationGroup_Id,
            int application_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Name).Capitalize(), application_Name),
                new NamedValue(nameof(releaseNumber_Scheme_Name).Capitalize(), releaseNumber_Scheme_Name),
                new NamedValue(nameof(issueTracking_Provider_Id).Capitalize(), issueTracking_Provider_Id),
                new NamedValue(nameof(buildNumber_Scheme_Name).Capitalize(), buildNumber_Scheme_Name),
                new NamedValue(nameof(allowMultipleActiveReleases_Indicator).Capitalize(), allowMultipleActiveReleases_Indicator.ToYnIndicator()),
                new NamedValue(nameof(allowMultipleActiveBuilds_Indicator).Capitalize(), allowMultipleActiveBuilds_Indicator.ToYnIndicator()),
                new NamedValue(nameof(applicationGroup_Id).Capitalize(), applicationGroup_Id),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Applications_CreateApplicationAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a deployable for a specified application, or updates an existing one
        /// </summary>
        /// <returns>Deployable_Id</returns>
        public async Task<int> Applications_CreateOrUpdateDeployableAsync(
            int deployable_Id,
            int application_Id,
            string deployable_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(deployable_Name).Capitalize(), deployable_Name)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Applications_CreateOrUpdateDeployableAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deactivates an application, removing it from menu options but preserves data
        /// </summary>
        public async Task<bool> Applications_DeactivateApplicationAsync(int application_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Applications_DeactivateApplicationAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes an existing imported deployable relation, but does not delete the deployable from the host application
        /// </summary>
        public async Task<bool> Applications_DeleteImportedDeployableAsync(
            int deployable_Id,
            int application_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Applications_DeleteImportedDeployableAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Edits an existing application
        /// </summary>
        public async Task<bool> Applications_EditApplicationAsync(
            int application_Id,
            string application_Name,
            string application_Description,
            int applicationGroup_Id,
            bool allowMultipleActiveReleases_Indicator,
            bool allowMultipleActiveBuilds_Indicator,
            string variableSupport_Code,
            string releaseNumber_Scheme_Name,
            string buildNumber_Scheme_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(application_Name).Capitalize(), application_Name),
                new NamedValue(nameof(application_Description).Capitalize(), application_Description),
                new NamedValue(nameof(applicationGroup_Id).Capitalize(), applicationGroup_Id),
                new NamedValue(nameof(allowMultipleActiveReleases_Indicator).Capitalize(), allowMultipleActiveReleases_Indicator.ToYnIndicator()),
                new NamedValue(nameof(allowMultipleActiveBuilds_Indicator).Capitalize(), allowMultipleActiveBuilds_Indicator.ToYnIndicator()),
                new NamedValue(nameof(variableSupport_Code).Capitalize(), variableSupport_Code),
                new NamedValue(nameof(releaseNumber_Scheme_Name).Capitalize(), releaseNumber_Scheme_Name),
                new NamedValue(nameof(buildNumber_Scheme_Name).Capitalize(), buildNumber_Scheme_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Applications_EditApplicationAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Searches for deployables in the system
        /// </summary>
        public async Task<IEnumerable<DeployableExtended>> Applications_FindDeployablesAsync(
            string searchTerm_Text,
            int max_Count)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(searchTerm_Text).Capitalize(), searchTerm_Text),
                new NamedValue(nameof(max_Count).Capitalize(), max_Count)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<DeployableExtended>>(nameof(Applications_FindDeployablesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of an application along with the associated deployables
        /// </summary>
        public async Task<ApplicationsExtendedDeployablesExtended> Applications_GetApplicationAsync(int application_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync<ApplicationsExtendedDeployablesExtended>(nameof(Applications_GetApplicationAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified number of applications in the system, or all if null is passed in
        /// </summary>
        public async Task<IEnumerable<ApplicationExtended>> Applications_GetApplicationsAsync(
            int? application_Count = null,
            bool includeInactive_Indicator = false)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Count).Capitalize(), application_Count),
                new NamedValue(nameof(includeInactive_Indicator).Capitalize(), includeInactive_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ApplicationExtended>>(nameof(Applications_GetApplicationsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all applications with imported deployables from a specified application
        /// </summary>
        public async Task<IEnumerable<ApplicationExtended>> Applications_GetDependentApplicationsAsync(int application_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ApplicationExtended>>(nameof(Applications_GetDependentApplicationsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified deployable
        /// </summary>
        public async Task<IEnumerable<DeployableExtended>> Applications_GetDeployableAsync(int deployable_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<DeployableExtended>>(nameof(Applications_GetDeployableAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a set of dependencies for the deployables in a given application or a specific deployable if one is specified
        /// </summary>
        public async Task<IEnumerable<DeployableDependency>> Applications_GetDeployableDependenciesAsync(
            int application_Id,
            int? deployable_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<DeployableDependency>>(nameof(Applications_GetDeployableDependenciesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the deployables for a specific application or for all applications
        /// </summary>
        public async Task<IEnumerable<DeployableExtended>> Applications_GetDeployablesAsync(int application_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<DeployableExtended>>(nameof(Applications_GetDeployablesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a set a imported deployables for a specified application
        /// </summary>
        public async Task<IEnumerable<DeployableImportedExtended>> Applications_GetImportedDeployablesAsync(int application_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<DeployableImportedExtended>>(nameof(Applications_GetImportedDeployablesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a view of all the latest executions grouped by application and environment, optionally filtered by application or application group
        /// </summary>
        public async Task<IEnumerable<ApplicationLatestEnvironmentExecution>> Applications_GetLatestEnvironmentExecutionsAsync(
            int application_Id,
            int applicationGroup_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(applicationGroup_Id).Capitalize(), applicationGroup_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ApplicationLatestEnvironmentExecution>>(nameof(Applications_GetLatestEnvironmentExecutionsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets only the active applications in the specified CSV string
        /// </summary>
        public async Task<IEnumerable<ApplicationSlim>> Applications_GetSpecifiedApplicationsAsync(string applicationIds_Csv)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(applicationIds_Csv).Capitalize(), applicationIds_Csv)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ApplicationSlim>>(nameof(Applications_GetSpecifiedApplicationsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Purges an entire application and all associated data from the system
        /// </summary>
        public async Task<bool> Applications_PurgeApplicationDataAsync(int application_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Applications_PurgeApplicationDataAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Purges a deployable and all its associations from the system
        /// </summary>
        public async Task<bool> Applications_PurgeDeployableDataAsync(int deployable_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Applications_PurgeDeployableDataAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Reactivates an application that has been deactivated
        /// </summary>
        public async Task<bool> Applications_ReactivateApplicationAsync(int application_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Applications_ReactivateApplicationAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Searches for applications by application name and group name that contain the search term
        /// </summary>
        public async Task<IEnumerable<ApplicationSlim>> Applications_SearchApplicationsAsync(string searchTerm_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(searchTerm_Text).Capitalize(), searchTerm_Text)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ApplicationSlim>>(nameof(Applications_SearchApplicationsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Sets the dependency relationships between the specified deployable and its dependents
        /// </summary>
        public async Task<bool> Applications_SetDeployableDependenciesAsync(
            int deployable_Id,
            string dependsOn_Deployables_Csv)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id),
                new NamedValue(nameof(dependsOn_Deployables_Csv).Capitalize(), dependsOn_Deployables_Csv)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Applications_SetDeployableDependenciesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Sets the issue tracking provider of a specified application
        /// </summary>
        public async Task<bool> Applications_SetIssueTrackerAsync(
            int application_Id,
            int issueTracking_Provider_Id,
            string issueTracking_CategoryIdList_Text,
            string issueTracking_Filter_Configuration,
            bool issueTracking_AllowBuildMasterIssues_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(issueTracking_Provider_Id).Capitalize(), issueTracking_Provider_Id),
                new NamedValue(nameof(issueTracking_CategoryIdList_Text).Capitalize(), issueTracking_CategoryIdList_Text),
                new NamedValue(nameof(issueTracking_Filter_Configuration).Capitalize(), issueTracking_Filter_Configuration),
                new NamedValue(nameof(issueTracking_AllowBuildMasterIssues_Indicator).Capitalize(), issueTracking_AllowBuildMasterIssues_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync(nameof(Applications_SetIssueTrackerAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
