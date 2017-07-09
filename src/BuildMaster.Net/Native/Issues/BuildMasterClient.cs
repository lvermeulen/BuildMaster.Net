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
        /// Closes a BuildMaster issue
        /// </summary>
        public async Task<bool> Issues_CloseIssueAsync(
            int application_Id,
            int issue_Id,
            string build_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(issue_Id).Capitalize(), issue_Id),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Issues_CloseIssueAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates an issue for a release of an application
        /// </summary>
        /// <returns>Issue_Id</returns>
        public async Task<int> Issues_CreateIssueAsync(
            int application_Id,
            string release_Number,
            string type_Text,
            string title_Text,
            string description_Text,
            bool closed_Indicator,
            string build_Number,
            string createdBy_User_Name,
            DateTime createdOn_Date,
            string issueTracker_IssueId_Text,
            string issueTracker_IssueStatus_Text,
            DateTime issueTracker_LastSync_Date,
            string issueTracker_IssueUrl_Text,
            int issue_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(type_Text).Capitalize(), type_Text),
                new NamedValue(nameof(title_Text).Capitalize(), title_Text),
                new NamedValue(nameof(description_Text).Capitalize(), description_Text),
                new NamedValue(nameof(closed_Indicator).Capitalize(), closed_Indicator.ToYnIndicator()),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number),
                new NamedValue(nameof(createdBy_User_Name).Capitalize(), createdBy_User_Name),
                new NamedValue(nameof(createdOn_Date).Capitalize(), createdOn_Date),
                new NamedValue(nameof(issueTracker_IssueId_Text).Capitalize(), issueTracker_IssueId_Text),
                new NamedValue(nameof(issueTracker_IssueStatus_Text).Capitalize(), issueTracker_IssueStatus_Text),
                new NamedValue(nameof(issueTracker_LastSync_Date).Capitalize(), issueTracker_LastSync_Date),
                new NamedValue(nameof(issueTracker_IssueUrl_Text).Capitalize(), issueTracker_IssueUrl_Text),
                new NamedValue(nameof(issue_Id).Capitalize(), issue_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Issues_CreateIssueAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes an issue
        /// </summary>
        public async Task<bool> Issues_DeleteIssueAsync(
            int application_Id,
            int issue_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(issue_Id).Capitalize(), issue_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Issues_DeleteIssueAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified issue
        /// </summary>
        public async Task<IssueExtended> Issues_GetIssueAsync(
            int application_Id,
            int issue_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(issue_Id).Capitalize(), issue_Id)
            );

            return await ExecuteNativeApiMethodAsync<IssueExtended>(nameof(Issues_GetIssueAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the issues for an application, optionally filtered by release or build
        /// </summary>
        public async Task<IEnumerable<IssueExtended>> Issues_GetIssuesAsync(
            int application_Id,
            string release_Number = null,
            string build_Number = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<IssueExtended>>(nameof(Issues_GetIssuesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of distinct issue types that have been synchronized by the system
        /// </summary>
        public async Task<IEnumerable<IssueType>> Issues_GetIssueTypesAsync() => 
            await ExecuteNativeApiMethodAsync<IEnumerable<IssueType>>(nameof(Issues_GetIssueTypesAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

        /// <summary>
        /// Re-opens a BuildMaster issue
        /// </summary>
        public async Task<bool> Issues_ReopenIssueAsync(
            int application_Id,
            int issue_Id,
            string build_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(issue_Id).Capitalize(), issue_Id),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Issues_ReopenIssueAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates one or more properties of an issue
        /// </summary>
        public async Task<bool> Issues_UpdateIssueAsync(
            int application_Id,
            int issue_Id,
            string release_Number,
            string type_Text,
            string title_Text,
            string description_Text,
            bool closed_Indicator,
            string issueTracker_IssueStatus_Text,
            string issueTracker_IssueUrl_Text,
            DateTime issueTracker_LastSync_Date,
            string openedOn_Original_Build_Number,
            string closedOn_Original_Build_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(issue_Id).Capitalize(), issue_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(type_Text).Capitalize(), type_Text),
                new NamedValue(nameof(title_Text).Capitalize(), title_Text),
                new NamedValue(nameof(description_Text).Capitalize(), description_Text),
                new NamedValue(nameof(closed_Indicator).Capitalize(), closed_Indicator.ToYnIndicator()),
                new NamedValue(nameof(issueTracker_IssueStatus_Text).Capitalize(), issueTracker_IssueStatus_Text),
                new NamedValue(nameof(issueTracker_IssueUrl_Text).Capitalize(), issueTracker_IssueUrl_Text),
                new NamedValue(nameof(issueTracker_LastSync_Date).Capitalize(), issueTracker_LastSync_Date),
                new NamedValue(nameof(openedOn_Original_Build_Number).Capitalize(), openedOn_Original_Build_Number),
                new NamedValue(nameof(closedOn_Original_Build_Number).Capitalize(), closedOn_Original_Build_Number)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Issues_UpdateIssueAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
