using System.Collections.Generic;
using System.Threading.Tasks;
using BuildMaster.Net.Common.Models;
using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        public async Task<Common.Models.Variables> GetAllReleaseConfigurationVariables(string applicationName, string releaseNumber) => await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}")
            .GetJsonAsync<Common.Models.Variables>();

        public async Task<bool> SetAllReleaseConfigurationVariables(string applicationName, string releaseNumber, Common.Models.Variables variables) => (await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}")
            .PutJsonAsync(variables))
            .IsSuccessStatusCode;

        public async Task<string> GetSingleReleaseConfigurationVariable(string applicationName, string releaseNumber, string variableName) => await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}/{variableName}")
            .GetStringAsync();

        public async Task<bool> SetSingleReleaseConfigurationVariable(string applicationName, string releaseNumber, Variable variable) => (await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}/{variable?.Name}")
            .PutStringAsync(variable?.Value))
            .IsSuccessStatusCode;

        public async Task<bool> DeleteSingleReleaseConfigurationVariable(string applicationName, string releaseNumber, string variableName) => (await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}/{variableName}")
            .DeleteAsync())
            .IsSuccessStatusCode;
    }
}
