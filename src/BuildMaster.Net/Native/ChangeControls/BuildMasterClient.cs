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
        /// Creates a new change control, or updates an existing one
        /// </summary>
        /// <returns>ChangeControl_Id</returns>
        public async Task<int> ChangeControls_CreateOrUpdateChangeControlAsync(
            int changeControl_Id,
            string changeControl_Name,
            int application_Id,
            string release_Number,
            string group_Name,
            string description_Text,
            string principal_Name,
            string principalType_Code,
            string performanceType_Code,
            bool active_Indicator,
            string environments_Csv)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(changeControl_Id).Capitalize(), changeControl_Id),
                new NamedValue(nameof(changeControl_Name).Capitalize(), changeControl_Name),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(group_Name).Capitalize(), group_Name),
                new NamedValue(nameof(description_Text).Capitalize(), description_Text),
                new NamedValue(nameof(principal_Name).Capitalize(), principal_Name),
                new NamedValue(nameof(principalType_Code).Capitalize(), principalType_Code),
                new NamedValue(nameof(performanceType_Code).Capitalize(), performanceType_Code),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(environments_Csv).Capitalize(), environments_Csv)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(ChangeControls_CreateOrUpdateChangeControlAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified change control
        /// </summary>
        public async Task<bool> ChangeControls_DeleteChangeControlAsync(int changeControl_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(changeControl_Id).Capitalize(), changeControl_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(ChangeControls_DeleteChangeControlAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of a specified change control
        /// </summary>
        public async Task<ChangeControlsExtendedChangeControlEnvironmentsExtended> ChangeControls_GetChangeControlAsync(int changeControl_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(changeControl_Id).Capitalize(), changeControl_Id)
            );

            return await ExecuteNativeApiMethodAsync<ChangeControlsExtendedChangeControlEnvironmentsExtended>(nameof(ChangeControls_GetChangeControlAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of change control performances for a specified change control or all change controls if none is specified
        /// </summary>
        public async Task<IEnumerable<ChangeControlPerformanceExtended>> ChangeControls_GetChangeControlPerformancesAsync(
            int application_Id,
            int changeControl_Id,
            string release_Number,
            bool includeInactive_Indicator,
            int environment_Id,
            int row_Count)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(changeControl_Id).Capitalize(), changeControl_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(includeInactive_Indicator).Capitalize(), includeInactive_Indicator.ToYnIndicator()),
                new NamedValue(nameof(environment_Id).Capitalize(), environment_Id),
                new NamedValue(nameof(row_Count).Capitalize(), row_Count)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ChangeControlPerformanceExtended>>(nameof(ChangeControls_GetChangeControlPerformancesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of change controls based on the specified criteria
        /// </summary>
        public async Task<ChangeControlsExtendedChangeControlEnvironmentsExtended> ChangeControls_GetChangeControlsAsync(
            int application_Id,
            string release_Number,
            bool includeInactive_Indicator,
            int changeControl_Count)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(includeInactive_Indicator).Capitalize(), includeInactive_Indicator.ToYnIndicator()),
                new NamedValue(nameof(changeControl_Count).Capitalize(), changeControl_Count)
            );

            return await ExecuteNativeApiMethodAsync<ChangeControlsExtendedChangeControlEnvironmentsExtended>(nameof(ChangeControls_GetChangeControlsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds a change control performance for a specified environment
        /// </summary>
        public async Task<bool> ChangeControls_PerformChangeControlAsync(
            int changeControl_Id,
            int environment_Id,
            string notes_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(changeControl_Id).Capitalize(), changeControl_Id),
                new NamedValue(nameof(environment_Id).Capitalize(), environment_Id),
                new NamedValue(nameof(notes_Text).Capitalize(), notes_Text)
            );

            return await ExecuteNativeApiMethodAsync(nameof(ChangeControls_PerformChangeControlAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
