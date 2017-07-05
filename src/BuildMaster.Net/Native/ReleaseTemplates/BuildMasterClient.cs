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
        /// Creates a release template or updates an existing one
        /// </summary>
        /// <returns>ReleaseTemplate_Id</returns>
        public async Task<int> ReleaseTemplates_CreateOrUpdateTemplateAsync(
            int application_Id,
            string releaseTemplate_Name,
            string releaseTemplate_Configuration,
            int releaseTemplate_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(releaseTemplate_Name).Capitalize(), releaseTemplate_Name),
                new NamedValue(nameof(releaseTemplate_Configuration).Capitalize(), releaseTemplate_Configuration),
                new NamedValue(nameof(releaseTemplate_Id).Capitalize(), releaseTemplate_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(ReleaseTemplates_CreateOrUpdateTemplateAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified release template
        /// </summary>
        public async Task<bool> ReleaseTemplates_DeleteTemplateAsync(int releaseTemplate_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(releaseTemplate_Id).Capitalize(), releaseTemplate_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(ReleaseTemplates_DeleteTemplateAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified release template
        /// </summary>
        public async Task<ReleaseTemplate> ReleaseTemplates_GetTemplateAsync(int releaseTemplate_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(releaseTemplate_Id).Capitalize(), releaseTemplate_Id)
            );

            return await ExecuteNativeApiMethodAsync<ReleaseTemplate>(nameof(ReleaseTemplates_GetTemplateAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified release template by application and name
        /// </summary>
        public async Task<ReleaseTemplate> ReleaseTemplates_GetTemplateByNameAsync(
            int application_Id,
            string releaseTemplate_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(releaseTemplate_Name).Capitalize(), releaseTemplate_Name)
            );

            return await ExecuteNativeApiMethodAsync<ReleaseTemplate>(nameof(ReleaseTemplates_GetTemplateByNameAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the release templates for the specified application
        /// </summary>
        public async Task<IEnumerable<ReleaseTemplate>> ReleaseTemplates_GetTemplatesAsync(int application_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ReleaseTemplate>>(nameof(ReleaseTemplates_GetTemplatesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
