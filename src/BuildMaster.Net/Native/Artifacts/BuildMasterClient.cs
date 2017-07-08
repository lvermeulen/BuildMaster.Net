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
        /// Creates a reference to an artifact in the artifact library
        /// </summary>
        public async Task<bool> Artifacts_CreateOrReplaceArtifactAsync(
            int application_Id,
            string release_Number,
            string build_Number,
            int deployable_Id,
            string artifact_Name,
            int execution_Id,
            string artifact_Path)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number),
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id),
                new NamedValue(nameof(artifact_Name).Capitalize(), artifact_Name),
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id),
                new NamedValue(nameof(artifact_Path).Capitalize(), artifact_Path)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Artifacts_CreateOrReplaceArtifactAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an artifact based on the specified criteria
        /// </summary>
        public async Task<BuildArtifactExtended> Artifacts_GetArtifactAsync(
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

            return await ExecuteNativeApiMethodAsync<BuildArtifactExtended>(nameof(Artifacts_GetArtifactAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a set of artifacts based on the specified criteria
        /// </summary>
        public async Task<IEnumerable<BuildArtifactExtended>> Artifacts_GetArtifactsAsync(
            int application_Id,
            string release_Number,
            string build_Number,
            int deployable_Id,
            int artifact_Count)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(build_Number).Capitalize(), build_Number),
                new NamedValue(nameof(deployable_Id).Capitalize(), deployable_Id),
                new NamedValue(nameof(artifact_Count).Capitalize(), artifact_Count)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildArtifactExtended>>(nameof(Artifacts_GetArtifactsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a set of artifacts that are associated with a specified build status, optionally filtered by application and release
        /// </summary>
        public async Task<IEnumerable<BuildArtifactSlim>> Artifacts_GetArtifactsByBuildStatusAsync(
            int application_Id,
            string release_Number,
            string buildStatus_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(release_Number).Capitalize(), release_Number),
                new NamedValue(nameof(buildStatus_Name).Capitalize(), buildStatus_Name)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildArtifactSlim>>(nameof(Artifacts_GetArtifactsByBuildStatusAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
