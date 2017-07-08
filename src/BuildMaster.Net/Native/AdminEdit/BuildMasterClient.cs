using System.Threading.Tasks;
using BuildMaster.Net.Common;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        /// <summary>
        /// Purges an artifact from the specified build
        /// </summary>
        public async Task<bool> AdminEdit_PurgeArtifactAsync(
            int application_Id,
            string release_Number,
            string build_Number,
            string artifact_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number),
                new NamedValue(nameof(artifact_Name).Capitalize(), artifact_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(AdminEdit_PurgeArtifactAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Purges an entire build and all associated data from the system
        /// </summary>
        public async Task<bool> AdminEdit_PurgeBuildAsync(
            int application_Id,
            string release_Number,
            string build_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number)
            );

            return await ExecuteNativeApiMethodAsync(nameof(AdminEdit_PurgeBuildAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the status of a build
        /// </summary>
        public async Task<bool> AdminEdit_UpdateBuildStatusAsync(
            int application_Id,
            string release_Number,
            string build_Number,
            string buildStatus_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number),
                new NamedValue(nameof(buildStatus_Name).Capitalize(), buildStatus_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(AdminEdit_UpdateBuildStatusAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the status of an execution
        /// </summary>
        public async Task<bool> AdminEdit_UpdateExecutionStatusAsync(
            int execution_Id,
            string executionStatus_Code)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id),
                new NamedValue(nameof(executionStatus_Code).Capitalize(), executionStatus_Code)
            );

            return await ExecuteNativeApiMethodAsync(nameof(AdminEdit_UpdateExecutionStatusAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the status of a promotion
        /// </summary>
        public async Task<bool> AdminEdit_UpdatePromotionStatusAsync(
            int promotion_Id,
            string promotionStatus_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(promotion_Id).Capitalize(), promotion_Id),
                new NamedValue(nameof(promotionStatus_Name).Capitalize(), promotionStatus_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(AdminEdit_UpdatePromotionStatusAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the status of a release
        /// </summary>
        public async Task<bool> AdminEdit_UpdateReleaseStatusAsync(
            int application_Id,
            string release_Number,
            string releaseStatus_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(releaseStatus_Name).Capitalize(), releaseStatus_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(AdminEdit_UpdateReleaseStatusAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
