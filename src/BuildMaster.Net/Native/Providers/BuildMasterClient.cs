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
        /// Creates a new provider or updates an existing one
        /// </summary>
        /// <returns>Provider_Id</returns>
        public async Task<int> Providers_CreateOrUpdateProviderAsync(
            int provider_Id,
            string providerType_Code,
            int executeOn_Server_Id,
            string provider_Name,
            string provider_Description,
            string provider_Configuration,
            bool internal_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(provider_Id).Capitalize(), provider_Id),
                new NamedValue(nameof(providerType_Code).Capitalize(), providerType_Code),
                new NamedValue(nameof(executeOn_Server_Id).Capitalize(), executeOn_Server_Id),
                new NamedValue(nameof(provider_Name).Capitalize(), provider_Name),
                new NamedValue(nameof(provider_Description).Capitalize(), provider_Description),
                new NamedValue(nameof(provider_Configuration).Capitalize(), provider_Configuration),
                new NamedValue(nameof(internal_Indicator).Capitalize(), internal_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Providers_CreateOrUpdateProviderAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified provider
        /// </summary>
        public async Task<bool> Providers_DeleteProviderAsync(int provider_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(provider_Id).Capitalize(), provider_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Providers_DeleteProviderAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of the specified provider
        /// </summary>
        public async Task<Provider> Providers_GetProviderAsync(int provider_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(provider_Id).Capitalize(), provider_Id)
            );

            return await ExecuteNativeApiMethodAsync<Provider>(nameof(Providers_GetProviderAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of providers in the system based on the specified criteria
        /// </summary>
        public async Task<IEnumerable<Provider>> Providers_GetProvidersAsync(
            string providerType_Code = null,
            int? application_Id = null,
            int? environment_Id = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(providerType_Code).Capitalize(), providerType_Code),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(environment_Id).Capitalize(), environment_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<Provider>>(nameof(Providers_GetProvidersAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
