using System.Collections.Generic;
using System.Threading.Tasks;
using BuildMaster.Net.Common;
using BuildMaster.Net.Models;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        /// <summary>
        /// Creates a new build of an application
        /// </summary>
        public async Task<bool> Builds_CreateBuildAsync(
            int application_Id,
            string release_Number,
            string build_Number,
            string buildImporter_Configuration)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number),
                new NamedValue(nameof(buildImporter_Configuration).Capitalize(), buildImporter_Configuration)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Builds_CreateBuildAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details for a specified build
        /// </summary>
        public async Task<BuildsExtended> Builds_GetBuildAsync(
            int application_Id,
            string release_Number,
            string build_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number)
            );

            return await ExecuteNativeApiMethodAsync<BuildsExtended>(nameof(Builds_GetBuildAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details for a specified build by ID
        /// </summary>
        public async Task<BuildsExtended> Builds_GetBuildByIdAsync(int build_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(build_Id).Capitalize(), build_Id)
            );

            return await ExecuteNativeApiMethodAsync<BuildsExtended>(nameof(Builds_GetBuildByIdAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details for all builds that match the specified criteria
        /// </summary>
        public async Task<IEnumerable<BuildsExtended>> Builds_GetBuildsAsync(
            int application_Id,
            string release_Number,
            string buildStatus_Name,
            int build_Count)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(buildStatus_Name).Capitalize(), buildStatus_Name),
                new NamedValue(nameof(build_Count).Capitalize(), build_Count)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildsExtended>>(nameof(Builds_GetBuildsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all details regarding a specific build execution
        /// </summary>
        public async Task<BuildExecutionsExtended> Builds_GetExecutionAsync(int execution_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id)
            );

            return await ExecuteNativeApiMethodAsync<BuildExecutionsExtended>(nameof(Builds_GetExecutionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        //TODO: returns (BuildExecutionsExtended, BuildExecution_DeploymentPlans, BuildExecution_DeploymentPlanActionGroups, BuildExecution_ActionGroupActions, BuildExecution_ActionGroupActionLogEntries)
        /// <summary>
        /// Gets all details regarding a specific build execution
        /// </summary>
        public async Task<BuildExecutionsExtended> Builds_GetExecutionExtendedAsync(int execution_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id)
            );

            return await ExecuteNativeApiMethodAsync<BuildExecutionsExtended>(nameof(Builds_GetExecutionExtendedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all the build executions for the specified build
        /// </summary>
        public async Task<IEnumerable<BuildExecutionsExtended>> Builds_GetExecutionsAsync(
            int application_Id,
            string release_Number,
            string build_Number,
            string pipelineStage_Name,
            int execution_Count)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number),
                new NamedValue(nameof(pipelineStage_Name).Capitalize(), pipelineStage_Name),
                new NamedValue(nameof(execution_Count).Capitalize(), execution_Count)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildExecutionsExtended>>(nameof(Builds_GetExecutionsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets recent build executions for the specified server
        /// </summary>
        public async Task<IEnumerable<BuildExecutionsExtended>> Builds_GetExecutionsByServerAsync(
            int server_Id,
            int execution_Count)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(server_Id).Capitalize(), server_Id),
                new NamedValue(nameof(execution_Count).Capitalize(), execution_Count)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildExecutionsExtended>>(nameof(Builds_GetExecutionsByServerAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all executions in the executing state optionally filtered by application
        /// </summary>
        public async Task<IEnumerable<BuildExecutionsExtended>> Builds_GetExecutionsInProgressAsync(int application_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildExecutionsExtended>>(nameof(Builds_GetExecutionsInProgressAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a build promotion
        /// </summary>
        public async Task<BuildPromotionsExtended> Builds_GetPromotionAsync(int promotion_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(promotion_Id).Capitalize(), promotion_Id)
            );

            return await ExecuteNativeApiMethodAsync<BuildPromotionsExtended>(nameof(Builds_GetPromotionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all of the promotions that have occurred
        /// </summary>
        public async Task<IEnumerable<BuildPromotionsExtended>> Builds_GetPromotionsAsync(
            int application_Id,
            string release_Number,
            string build_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildPromotionsExtended>>(nameof(Builds_GetPromotionsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Promotes a build to to a pipeline stage
        /// </summary>
        /// <returns>Promotion_Id</returns>
        public async Task<int> Builds_PromoteBuildAsync(
            int application_Id,
            string release_Number,
            string build_Number,
            string comments_Text,
            bool forcePromotion_Indicator,
            string promoteTo_PipelineStage_Name,
            bool setFurthestStage_Indicator,
            int promotion_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number),
                new NamedValue(nameof(comments_Text).Capitalize(), comments_Text),
                new NamedValue(nameof(forcePromotion_Indicator).Capitalize(), forcePromotion_Indicator.ToYnIndicator()),
                new NamedValue(nameof(promoteTo_PipelineStage_Name).Capitalize(), promoteTo_PipelineStage_Name),
                new NamedValue(nameof(setFurthestStage_Indicator).Capitalize(), setFurthestStage_Indicator.ToYnIndicator()),
                new NamedValue(nameof(promotion_Id).Capitalize(), promotion_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Builds_PromoteBuildAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Purges an entire build and all associated data from the system
        /// </summary>
        public async Task<bool> Builds_PurgeBuildDataAsync(
            int application_Id,
            string release_Number,
            string build_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Builds_PurgeBuildDataAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Rejects the specified build
        /// </summary>
        public async Task<bool> Builds_RejectBuildAsync(
            int application_Id,
            string release_Number,
            string build_Number,
            string rejection_Notes)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number),
                new NamedValue(nameof(rejection_Notes).Capitalize(), rejection_Notes)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Builds_RejectBuildAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Sets the build number of a build
        /// </summary>
        public async Task<bool> Builds_SetBuildNumberAsync(
            int build_Id,
            string build_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(build_Id).Capitalize(), build_Id),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Builds_SetBuildNumberAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
