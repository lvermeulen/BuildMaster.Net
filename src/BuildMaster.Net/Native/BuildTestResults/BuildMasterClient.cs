using System;
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
        /// Gets all of the test result groups in the system
        /// </summary>
        public async Task<IEnumerable<BuildTestResultsAllGroups>> BuildTestResults_GetAllGroupsAsync() => 
            await ExecuteNativeApiMethodAsync<IEnumerable<BuildTestResultsAllGroups>>(nameof(BuildTestResults_GetAllGroupsAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

        /// <summary>
        /// Gets the unit test results for a specified build execution
        /// </summary>
        public async Task<IEnumerable<BuildTestResultsTestGroupResults>> BuildTestResults_GetTestGroupResultsAsync(int execution_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildTestResultsTestGroupResults>>(nameof(BuildTestResults_GetTestGroupResultsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the unit test results for the specified build
        /// </summary>
        public async Task<IEnumerable<BuildTestResultsTestGroupResults>> BuildTestResults_GetTestGroupResultsForBuildAsync(
            int application_Id,
            string release_Number,
            string build_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildTestResultsTestGroupResults>>(nameof(BuildTestResults_GetTestGroupResultsForBuildAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the history of a test by its name, and optionally filtered by test group and application
        /// </summary>
        public async Task<IEnumerable<BuildTestResultExtended>> BuildTestResults_GetTestHistoryAsync(
            string test_Name,
            string group_Name,
            int application_Id,
            string testStatus_Code,
            int row_Count)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(test_Name).Capitalize(), test_Name),
                new NamedValue(nameof(group_Name).Capitalize(), group_Name),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(testStatus_Code).Capitalize(), testStatus_Code),
                new NamedValue(nameof(row_Count).Capitalize(), row_Count)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildTestResultExtended>>(nameof(BuildTestResults_GetTestHistoryAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the results of a specific unit test
        /// </summary>
        public async Task<IEnumerable<BuildTestResultExtended>> BuildTestResults_GetTestLogAsync(
            int execution_Id,
            string group_Name,
            int? test_Sequence = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id),
                new NamedValue(nameof(group_Name).Capitalize(), group_Name),
                new NamedValue(nameof(test_Sequence).Capitalize(), test_Sequence)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildTestResultExtended>>(nameof(BuildTestResults_GetTestLogAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the build test results based on the specified criteria
        /// </summary>
        public async Task<IEnumerable<BuildTestResultExtended>> BuildTestResults_GetTestResultsAsync(
            int execution_Id,
            string group_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id),
                new NamedValue(nameof(group_Name).Capitalize(), group_Name)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildTestResultExtended>>(nameof(BuildTestResults_GetTestResultsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Logs the result of an individual unit test
        /// </summary>
        public async Task<bool> BuildTestResults_RecordTestResultAsync(
            int execution_Id,
            string group_Name,
            string test_Name,
            string testStatus_Code,
            string testResult_Text,
            DateTime? testStarted_Date,
            DateTime? testEnded_Date)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id),
                new NamedValue(nameof(group_Name).Capitalize(), group_Name),
                new NamedValue(nameof(test_Name).Capitalize(), test_Name),
                new NamedValue(nameof(testStatus_Code).Capitalize(), testStatus_Code),
                new NamedValue(nameof(testResult_Text).Capitalize(), testResult_Text),
                new NamedValue(nameof(testStarted_Date).Capitalize(), testStarted_Date),
                new NamedValue(nameof(testEnded_Date).Capitalize(), testEnded_Date)
            );

            return await ExecuteNativeApiMethodAsync(nameof(BuildTestResults_RecordTestResultAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
