using System.Collections.Generic;
using System.Threading.Tasks;
using BuildMaster.Net.Common;
using BuildMaster.Net.Native.Models;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        /// <summary>
        /// Creates a new credential or updates an existing one
        /// </summary>
        /// <returns>Credential_Id</returns>
        public async Task<int> Credentials_CreateOrUpdateCredentialAsync(
            string credential_Name,
            int environment_Id,
            string credentialType_Name,
            string configuration_Xml,
            bool allowFunctionAccess_Indicator,
            int credential_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(credential_Name).Capitalize(), credential_Name),
                new NamedValue(nameof(environment_Id).Capitalize(), environment_Id),
                new NamedValue(nameof(credentialType_Name).Capitalize(), credentialType_Name),
                new NamedValue(nameof(configuration_Xml).Capitalize(), configuration_Xml),
                new NamedValue(nameof(allowFunctionAccess_Indicator).Capitalize(), allowFunctionAccess_Indicator.ToYnIndicator()),
                new NamedValue(nameof(credential_Id).Capitalize(), credential_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Credentials_CreateOrUpdateCredentialAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified credential
        /// </summary>
        public async Task<bool> Credentials_DeleteCredentialAsync(int credential_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(credential_Id).Capitalize(), credential_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Credentials_DeleteCredentialAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified credential
        /// </summary>
        public async Task<CredentialsExtended> Credentials_GetCredentialAsync(int credential_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(credential_Id).Capitalize(), credential_Id)
            );

            return await ExecuteNativeApiMethodAsync<CredentialsExtended>(nameof(Credentials_GetCredentialAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified credential by its qualified name
        /// </summary>
        public async Task<CredentialsExtended> Credentials_GetCredentialByNameAsync(
            string credentialType_Name,
            string credential_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(credentialType_Name).Capitalize(), credentialType_Name),
                new NamedValue(nameof(credential_Name).Capitalize(), credential_Name)
            );

            return await ExecuteNativeApiMethodAsync<CredentialsExtended>(nameof(Credentials_GetCredentialByNameAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all credentials in the system
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CredentialsExtended>> Credentials_GetCredentialsAsync() => 
            await ExecuteNativeApiMethodAsync<IEnumerable<CredentialsExtended>>(nameof(Credentials_GetCredentialsAsync).WithoutAsyncSuffix()).ConfigureAwait(false);
    }
}
