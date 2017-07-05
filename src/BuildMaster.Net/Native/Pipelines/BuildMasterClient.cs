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
        /// Creates a new pipeline
        /// </summary>
        /// <returns>Pipeline_Id</returns>
        public async Task<int> Pipelines_CreatePipelineAsync(
            string pipeline_Name,
            string pipeline_Configuration,
            bool active_Indicator,
            int application_Id,
            string pipeline_Color,
            int pipeline_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(pipeline_Name).Capitalize(), pipeline_Name),
                new NamedValue(nameof(pipeline_Configuration).Capitalize(), pipeline_Configuration),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(pipeline_Color).Capitalize(), pipeline_Color),
                new NamedValue(nameof(pipeline_Id).Capitalize(), pipeline_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Pipelines_CreatePipelineAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a pipeline
        /// </summary>
        public async Task<bool> Pipelines_DeletePipelineAsync(int pipeline_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(pipeline_Id).Capitalize(), pipeline_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Pipelines_DeletePipelineAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the specified pipeline
        /// </summary>
        public async Task<Pipeline> Pipelines_GetPipelineAsync(int pipeline_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(pipeline_Id).Capitalize(), pipeline_Id)
            );

            return await ExecuteNativeApiMethodAsync<Pipeline>(nameof(Pipelines_GetPipelineAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the pipelines in the system, optionally filtered by application
        /// </summary>
        public async Task<IEnumerable<Pipeline>> Pipelines_GetPipelinesAsync(int? application_Id = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<Pipeline>>(nameof(Pipelines_GetPipelinesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates a pipeline
        /// </summary>
        public async Task<bool> Pipelines_UpdatePipelineAsync(
            int pipeline_Id,
            string pipeline_Name,
            string pipeline_Configuration,
            bool active_Indicator,
            string pipeline_Color)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(pipeline_Id).Capitalize(), pipeline_Id),
                new NamedValue(nameof(pipeline_Name).Capitalize(), pipeline_Name),
                new NamedValue(nameof(pipeline_Configuration).Capitalize(), pipeline_Configuration),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(pipeline_Color).Capitalize(), pipeline_Color)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Pipelines_UpdatePipelineAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
