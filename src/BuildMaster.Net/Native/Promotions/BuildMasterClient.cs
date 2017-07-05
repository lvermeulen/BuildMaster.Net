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
        /// Adds an approval for a promotion
        /// </summary>
        /// <returns>Approval_Id</returns>
        public async Task<int> Promotions_AddApprovalAsync(
            int application_Id,
            string release_Number,
            string build_Number,
            string pipelineStage_Name,
            int requirement_Id,
            string requirementType_Code,
            string user_Name,
            string requirement_Description,
            string comments_Text,
            int approval_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number),
                new NamedValue(nameof(pipelineStage_Name).Capitalize(), pipelineStage_Name),
                new NamedValue(nameof(requirement_Id).Capitalize(), requirement_Id),
                new NamedValue(nameof(requirementType_Code).Capitalize(), requirementType_Code),
                new NamedValue(nameof(user_Name).Capitalize(), user_Name),
                new NamedValue(nameof(requirement_Description).Capitalize(), requirement_Description),
                new NamedValue(nameof(comments_Text).Capitalize(), comments_Text),
                new NamedValue(nameof(approval_Id).Capitalize(), approval_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Promotions_AddApprovalAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes an approval for a promotion
        /// </summary>
        public async Task<bool> Promotions_DeleteApprovalAsync(int approval_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(approval_Id).Capitalize(), approval_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Promotions_DeleteApprovalAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all requirements and approvals received for the specified promotion
        /// </summary>
        public async Task<IEnumerable<BuildApprovalsReceivedExtended>> Promotions_GetApprovalsReceivedAsync(
            int application_Id,
            string release_Number,
            string build_Number,
            string pipelineStage_Name,
            int approval_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number),
                new NamedValue(nameof(pipelineStage_Name).Capitalize(), pipelineStage_Name),
                new NamedValue(nameof(approval_Id).Capitalize(), approval_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildApprovalsReceivedExtended>>(nameof(Promotions_GetApprovalsReceivedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets scheduled promotions, optionally filtered by promotion and date
        /// </summary>
        public async Task<IEnumerable<BuildPromotionsScheduledExtended>> Promotions_GetScheduledAsync(
            int application_Id,
            string release_Number,
            string build_Number,
            string pipelineStage_Name,
            DateTime? before_Date)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number),
                new NamedValue(nameof(pipelineStage_Name).Capitalize(), pipelineStage_Name),
                new NamedValue(nameof(before_Date).Capitalize(), before_Date)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildPromotionsScheduledExtended>>(nameof(Promotions_GetScheduledAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Schedules a promotion or removes a previously scheduled promotion
        /// </summary>
        public async Task<bool> Promotions_SchedulePromotionAsync(
            int application_Id,
            string release_Number,
            string build_Number,
            string pipelineStage_Name,
            DateTime promoteOn_Date)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number),
                new NamedValue(nameof(pipelineStage_Name).Capitalize(), pipelineStage_Name),
                new NamedValue(nameof(promoteOn_Date).Capitalize(), promoteOn_Date)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Promotions_SchedulePromotionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
