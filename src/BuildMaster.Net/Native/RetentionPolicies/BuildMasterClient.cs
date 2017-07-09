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
        /// Creates or updates a retention policy
        /// </summary>
        /// <returns>RetentionPolicy_Id</returns>
        public async Task<int> RetentionPolicies_CreateOrUpdateRetentionPolicyAsync(
            string retentionPolicy_Name,
            string purgeType_Code,
            int purgeIn_Application_Id,
            int purgeIn_ApplicationGroup_Id,
            bool purgeIn_OnlyDeployedReleases_Indicator,
            bool purgeIn_OnlyRejectedBuilds_Indicator,
            bool purgeOrphanedArtifacts_Indicator,
            int purgeIn_Pipeline_Id,
            int purgeIn_Environment_Id,
            bool purgeIn_BuildStep_Indicator,
            int retention_Count,
            long retention_Size,
            int retention_Days_Count,
            int purgeWindow_Start_Minutes,
            int purgeWindow_Duration_Minutes,
            bool active_Indicator,
            int retentionPolicy_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(retentionPolicy_Name).Capitalize(), retentionPolicy_Name),
                new NamedValue(nameof(purgeType_Code).Capitalize(), purgeType_Code),
                new NamedValue(nameof(purgeIn_Application_Id).Capitalize(), purgeIn_Application_Id),
                new NamedValue(nameof(purgeIn_ApplicationGroup_Id).Capitalize(), purgeIn_ApplicationGroup_Id),
                new NamedValue(nameof(purgeIn_OnlyDeployedReleases_Indicator).Capitalize(), purgeIn_OnlyDeployedReleases_Indicator.ToYnIndicator()),
                new NamedValue(nameof(purgeIn_OnlyRejectedBuilds_Indicator).Capitalize(), purgeIn_OnlyRejectedBuilds_Indicator.ToYnIndicator()),
                new NamedValue(nameof(purgeOrphanedArtifacts_Indicator).Capitalize(), purgeOrphanedArtifacts_Indicator.ToYnIndicator()),
                new NamedValue(nameof(purgeIn_Pipeline_Id).Capitalize(), purgeIn_Pipeline_Id),
                new NamedValue(nameof(purgeIn_Environment_Id).Capitalize(), purgeIn_Environment_Id),
                new NamedValue(nameof(purgeIn_BuildStep_Indicator).Capitalize(), purgeIn_BuildStep_Indicator.ToYnIndicator()),
                new NamedValue(nameof(retention_Count).Capitalize(), retention_Count),
                new NamedValue(nameof(retention_Size).Capitalize(), retention_Size),
                new NamedValue(nameof(retention_Days_Count).Capitalize(), retention_Days_Count),
                new NamedValue(nameof(purgeWindow_Start_Minutes).Capitalize(), purgeWindow_Start_Minutes),
                new NamedValue(nameof(purgeWindow_Duration_Minutes).Capitalize(), purgeWindow_Duration_Minutes),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(retentionPolicy_Id).Capitalize(), retentionPolicy_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(RetentionPolicies_CreateOrUpdateRetentionPolicyAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a retention policy
        /// </summary>
        public async Task<bool> RetentionPolicies_DeleteRetentionPolicyAsync(int retentionPolicy_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(retentionPolicy_Id).Capitalize(), retentionPolicy_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(RetentionPolicies_DeleteRetentionPolicyAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the purge history for one or all retention policies
        /// </summary>
        public async Task<IEnumerable<RetentionPolicyPurgeHistory>> RetentionPolicies_GetPurgeHistoryAsync(
            int retentionPolicy_Id,
            int max_Count)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(retentionPolicy_Id).Capitalize(), retentionPolicy_Id),
                new NamedValue(nameof(max_Count).Capitalize(), max_Count)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<RetentionPolicyPurgeHistory>>(nameof(RetentionPolicies_GetPurgeHistoryAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified purge history log
        /// </summary>
        public async Task<RetentionPolicyPurgeHistory> RetentionPolicies_GetPurgeLogAsync(int retentionPoliciesPurgeHistoryEntry_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(retentionPoliciesPurgeHistoryEntry_Id).Capitalize(), retentionPoliciesPurgeHistoryEntry_Id)
            );

            return await ExecuteNativeApiMethodAsync<RetentionPolicyPurgeHistory>(nameof(RetentionPolicies_GetPurgeLogAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all of the retention policies
        /// </summary>
        public async Task<IEnumerable<RetentionPolicyExtended>> RetentionPolicies_GetRetentionPoliciesAsync(string include_Inactive)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(include_Inactive).Capitalize(), include_Inactive)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<RetentionPolicyExtended>>(nameof(RetentionPolicies_GetRetentionPoliciesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified retention policy
        /// </summary>
        public async Task<RetentionPolicyExtended> RetentionPolicies_GetRetentionPolicyAsync(int retentionPolicy_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(retentionPolicy_Id).Capitalize(), retentionPolicy_Id)
            );

            return await ExecuteNativeApiMethodAsync<RetentionPolicyExtended>(nameof(RetentionPolicies_GetRetentionPolicyAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Marks a retention policy as ready to run immediately
        /// </summary>
        public async Task<bool> RetentionPolicies_PurgeNowAsync(int retentionPolicy_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(retentionPolicy_Id).Capitalize(), retentionPolicy_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(RetentionPolicies_PurgeNowAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
