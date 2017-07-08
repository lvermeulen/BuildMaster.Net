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
        /// Creates a recurring build based on the specified parameters, or updates an existing schedule if one with the given ID already exists
        /// </summary>
        /// <returns>Schedule_Id</returns>
        public async Task<int> BuildSchedules_CreateOrUpdateRecurringAsync(
            int schedule_Id,
            string schedule_Name,
            int application_Id,
            int startTime_Minutes,
            int endTime_Minutes,
            int dailyInterval_Minutes,
            string recurrence_Type,
            int recurrenceFrequency_Value,
            string recurrenceWeeklyDay_Mask,
            int recurrenceMonthlyDay_Value,
            string recurrenceMonthlyRelativity_Type,
            string recurrenceMonthlyRelativityDay_Type,
            string recurrenceMonthlyRelativityWeek_Type,
            int recurrenceMonthlyRelativityWeekDay_Value,
            string releaseFilter_ReleaseType_Code,
            int releaseFilter_Pipeline_Id,
            string buildImporter_Configuration,
            bool active_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(schedule_Id).Capitalize(), schedule_Id),
                new NamedValue(nameof(schedule_Name).Capitalize(), schedule_Name),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(startTime_Minutes).Capitalize(), startTime_Minutes),
                new NamedValue(nameof(endTime_Minutes).Capitalize(), endTime_Minutes),
                new NamedValue(nameof(dailyInterval_Minutes).Capitalize(), dailyInterval_Minutes),
                new NamedValue(nameof(recurrence_Type).Capitalize(), recurrence_Type),
                new NamedValue(nameof(recurrenceFrequency_Value).Capitalize(), recurrenceFrequency_Value),
                new NamedValue(nameof(recurrenceWeeklyDay_Mask).Capitalize(), recurrenceWeeklyDay_Mask),
                new NamedValue(nameof(recurrenceMonthlyDay_Value).Capitalize(), recurrenceMonthlyDay_Value),
                new NamedValue(nameof(recurrenceMonthlyRelativity_Type).Capitalize(), recurrenceMonthlyRelativity_Type),
                new NamedValue(nameof(recurrenceMonthlyRelativityDay_Type).Capitalize(), recurrenceMonthlyRelativityDay_Type),
                new NamedValue(nameof(recurrenceMonthlyRelativityWeek_Type).Capitalize(), recurrenceMonthlyRelativityWeek_Type),
                new NamedValue(nameof(recurrenceMonthlyRelativityWeekDay_Value).Capitalize(), recurrenceMonthlyRelativityWeekDay_Value),
                new NamedValue(nameof(releaseFilter_ReleaseType_Code).Capitalize(), releaseFilter_ReleaseType_Code),
                new NamedValue(nameof(releaseFilter_Pipeline_Id).Capitalize(), releaseFilter_Pipeline_Id),
                new NamedValue(nameof(buildImporter_Configuration).Capitalize(), buildImporter_Configuration),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(BuildSchedules_CreateOrUpdateRecurringAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a scheduled build based on the specified parameters, or updates an existing scheduled build if one with the given ID already exists
        /// </summary>
        /// <returns>Schedule_Id</returns>
        public async Task<int> BuildSchedules_CreateOrUpdateScheduleAsync(
            int schedule_Id,
            string schedule_Name,
            int application_Id,
            bool active_Indicator,
            string schedule_Type,
            int startTime_Minutes,
            int endTime_Minutes,
            int dailyInterval_Minutes,
            string recurrence_Type,
            int recurrenceFrequency_Value,
            string recurrenceWeeklyDay_Mask,
            int recurrenceMonthlyDay_Value,
            string recurrenceMonthlyRelativity_Type,
            string recurrenceMonthlyRelativityDay_Type,
            string recurrenceMonthlyRelativityWeek_Type,
            int recurrenceMonthlyRelativityWeekDay_Value,
            string url_AllowedIP_CSV,
            string url_Username_Text,
            string url_Password_Text,
            string sourceControl_Path_Name,
            int sourceControl_Provider_Id,
            int sourceControl_QuietPeriod_Minutes,
            string releaseFilter_ReleaseType_Code,
            int releaseFilter_Pipeline_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(schedule_Id).Capitalize(), schedule_Id),
                new NamedValue(nameof(schedule_Name).Capitalize(), schedule_Name),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(schedule_Type).Capitalize(), schedule_Type),
                new NamedValue(nameof(startTime_Minutes).Capitalize(), startTime_Minutes),
                new NamedValue(nameof(endTime_Minutes).Capitalize(), endTime_Minutes),
                new NamedValue(nameof(dailyInterval_Minutes).Capitalize(), dailyInterval_Minutes),
                new NamedValue(nameof(recurrence_Type).Capitalize(), recurrence_Type),
                new NamedValue(nameof(recurrenceFrequency_Value).Capitalize(), recurrenceFrequency_Value),
                new NamedValue(nameof(recurrenceWeeklyDay_Mask).Capitalize(), recurrenceWeeklyDay_Mask),
                new NamedValue(nameof(recurrenceMonthlyDay_Value).Capitalize(), recurrenceMonthlyDay_Value),
                new NamedValue(nameof(recurrenceMonthlyRelativity_Type).Capitalize(), recurrenceMonthlyRelativity_Type),
                new NamedValue(nameof(recurrenceMonthlyRelativityDay_Type).Capitalize(), recurrenceMonthlyRelativityDay_Type),
                new NamedValue(nameof(recurrenceMonthlyRelativityWeek_Type).Capitalize(), recurrenceMonthlyRelativityWeek_Type),
                new NamedValue(nameof(recurrenceMonthlyRelativityWeekDay_Value).Capitalize(), recurrenceMonthlyRelativityWeekDay_Value),
                new NamedValue(nameof(url_AllowedIP_CSV).Capitalize(), url_AllowedIP_CSV),
                new NamedValue(nameof(url_Username_Text).Capitalize(), url_Username_Text),
                new NamedValue(nameof(url_Password_Text).Capitalize(), url_Password_Text),
                new NamedValue(nameof(sourceControl_Path_Name).Capitalize(), sourceControl_Path_Name),
                new NamedValue(nameof(sourceControl_Provider_Id).Capitalize(), sourceControl_Provider_Id),
                new NamedValue(nameof(sourceControl_QuietPeriod_Minutes).Capitalize(), sourceControl_QuietPeriod_Minutes),
                new NamedValue(nameof(releaseFilter_ReleaseType_Code).Capitalize(), releaseFilter_ReleaseType_Code),
                new NamedValue(nameof(releaseFilter_Pipeline_Id).Capitalize(), releaseFilter_Pipeline_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(BuildSchedules_CreateOrUpdateScheduleAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a source control triggered automated build based on the specified parameters, or updates an existing one if one with a given ID already exists
        /// </summary>
        /// <returns>Schedule_Id</returns>
        public async Task<int> BuildSchedules_CreateOrUpdateSCMTriggeredAsync(
            int schedule_Id,
            string schedule_Name,
            int application_Id,
            string sourceControl_Path_Name,
            int sourceControl_Provider_Id,
            int sourceControl_QuietPeriod_Minutes,
            string releaseFilter_ReleaseType_Code,
            int releaseFilter_Pipeline_Id,
            bool active_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(schedule_Id).Capitalize(), schedule_Id),
                new NamedValue(nameof(schedule_Name).Capitalize(), schedule_Name),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(sourceControl_Path_Name).Capitalize(), sourceControl_Path_Name),
                new NamedValue(nameof(sourceControl_Provider_Id).Capitalize(), sourceControl_Provider_Id),
                new NamedValue(nameof(sourceControl_QuietPeriod_Minutes).Capitalize(), sourceControl_QuietPeriod_Minutes),
                new NamedValue(nameof(releaseFilter_ReleaseType_Code).Capitalize(), releaseFilter_ReleaseType_Code),
                new NamedValue(nameof(releaseFilter_Pipeline_Id).Capitalize(), releaseFilter_Pipeline_Id),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(BuildSchedules_CreateOrUpdateSCMTriggeredAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a URL-triggered build based on the specified parameters, or updates an existing schedule if one with the given ID already exists
        /// </summary>
        /// <returns>Schedule_Id</returns>
        public async Task<int> BuildSchedules_CreateOrUpdateURLTriggeredAsync(
            int schedule_Id,
            string schedule_Name,
            int application_Id,
            string url_AllowedIP_CSV,
            string url_Username_Text,
            string url_Password_Text,
            string releaseFilter_ReleaseType_Code,
            int releaseFilter_Pipeline_Id,
            string buildImporter_Configuration,
            bool active_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(schedule_Id).Capitalize(), schedule_Id),
                new NamedValue(nameof(schedule_Name).Capitalize(), schedule_Name),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(url_AllowedIP_CSV).Capitalize(), url_AllowedIP_CSV),
                new NamedValue(nameof(url_Username_Text).Capitalize(), url_Username_Text),
                new NamedValue(nameof(url_Password_Text).Capitalize(), url_Password_Text),
                new NamedValue(nameof(releaseFilter_ReleaseType_Code).Capitalize(), releaseFilter_ReleaseType_Code),
                new NamedValue(nameof(releaseFilter_Pipeline_Id).Capitalize(), releaseFilter_Pipeline_Id),
                new NamedValue(nameof(buildImporter_Configuration).Capitalize(), buildImporter_Configuration),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(BuildSchedules_CreateOrUpdateURLTriggeredAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified build schedule
        /// </summary>
        public async Task<bool> BuildSchedules_DeleteBuildScheduleAsync(int schedule_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(schedule_Id).Capitalize(), schedule_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(BuildSchedules_DeleteBuildScheduleAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified build schedule
        /// </summary>
        public async Task<BuildScheduleExtendedBuildScheduleVariableDefinitionsExtended> BuildSchedules_GetBuildScheduleAsync(int schedule_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(schedule_Id).Capitalize(), schedule_Id)
            );

            return await ExecuteNativeApiMethodAsync<BuildScheduleExtendedBuildScheduleVariableDefinitionsExtended>(nameof(BuildSchedules_GetBuildScheduleAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a set of builds schedules for the specified application and active indicator, or all if null is supplied
        /// </summary>
        public async Task<IEnumerable<BuildScheduleExtended>> BuildSchedules_GetBuildSchedulesAsync(
            int? application_Id = null,
            bool? active_Indicator = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildScheduleExtended>>(nameof(BuildSchedules_GetBuildSchedulesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates a variable definition to use with a scheduled build
        /// </summary>
        public async Task<bool> BuildSchedules_SetVariableDefinitionAsync(
            int schedule_Id,
            int variableDeclaration_Id,
            string value_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(schedule_Id).Capitalize(), schedule_Id),
                new NamedValue(nameof(variableDeclaration_Id).Capitalize(), variableDeclaration_Id),
                new NamedValue(nameof(value_Text).Capitalize(), value_Text)
            );

            return await ExecuteNativeApiMethodAsync(nameof(BuildSchedules_SetVariableDefinitionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
