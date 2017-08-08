using System.Collections.Generic;
using System.Threading.Tasks;
using BuildMaster.Net.Common.Models;
using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        public async Task<Common.Models.Variables> GetAllPackageConfigurationVariables(string applicationName, string releaseNumber, string packageNumber) => await GetVariablesApiClient($"packages/{applicationName}/{releaseNumber}/{packageNumber}")
            .GetJsonAsync<Common.Models.Variables>();

        public async Task<bool> SetAllPackageConfigurationVariables(string applicationName, string releaseNumber, string packageNumber, IEnumerable<Variable> variables) => (await GetVariablesApiClient($"packages/{applicationName}/{releaseNumber}/{packageNumber}")
            .PutJsonAsync(variables))
            .IsSuccessStatusCode;

        public async Task<string> GetSinglePackageConfigurationVariable(string applicationName, string releaseNumber, string packageNumber, string variableName) => await GetVariablesApiClient($"packages/{applicationName}/{releaseNumber}/{packageNumber}/{variableName}")
            .GetStringAsync();

        public async Task<bool> SetSinglePackageConfigurationVariable(string applicationName, string releaseNumber, string packageNumber, Variable variable) => (await GetVariablesApiClient($"packages/{applicationName}/{releaseNumber}/{packageNumber}/{variable?.Name}")
            .PutJsonAsync(variable))
            .IsSuccessStatusCode;

        public async Task<bool> DeleteSinglePackageConfigurationVariable(string applicationName, string releaseNumber, string packageNumber, string variableName) => (await GetVariablesApiClient($"packages/{applicationName}/{releaseNumber}/{packageNumber}/{variableName}")
            .DeleteAsync())
            .IsSuccessStatusCode;
    }
}
