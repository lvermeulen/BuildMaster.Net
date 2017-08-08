using System.Collections.Generic;
using System.Threading.Tasks;
using BuildMaster.Net.Common.Models;
using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        public async Task<Common.Models.Variables> GetAllGlobalConfigurationVariables() => await GetVariablesApiClient("global")
            .GetJsonAsync<Common.Models.Variables>();

        public async Task<bool> SetAllGlobalConfigurationVariables(IEnumerable<Variable> variables) => (await GetVariablesApiClient("global").PutJsonAsync(variables))
            .IsSuccessStatusCode;

        public async Task<string> GetSingleGlobalConfigurationVariable(string variableName) => await GetVariablesApiClient($"global/{variableName}")
            .GetStringAsync();

        public async Task<bool> SetSingleGlobalConfigurationVariable(Variable variable) => (await GetVariablesApiClient($"global/{variable?.Name}").PutJsonAsync(variable))
            .IsSuccessStatusCode;

        public async Task<bool> DeleteSingleGlobalConfigurationVariable(string variableName) => (await GetVariablesApiClient($"global/{variableName}").DeleteAsync())
            .IsSuccessStatusCode;
    }
}
