using System.Collections.Generic;
using System.Threading.Tasks;
using BuildMaster.Net.Common.Models;
using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        public async Task<IEnumerable<ScopedVariable>> GetAllScopedConfigurationVariables() => await GetVariablesApiClient("scoped/all")
            .GetJsonAsync<IEnumerable<ScopedVariable>>();

        public async Task<bool> SetAllScopedConfigurationVariables(IEnumerable<ScopedVariable> variables) => (await GetVariablesApiClient("scoped/all")
            .PutJsonAsync(variables))
            .IsSuccessStatusCode;

        public async Task<string> GetSingleScopedConfigurationVariable(string variableName) => await GetVariablesApiClient($"scoped/single/{variableName}")
            .GetStringAsync();

        public async Task<bool> SetSingleScopedConfigurationVariable(ScopedVariable variable) => (await GetVariablesApiClient($"scoped/single/{variable?.Name}")
            .PutJsonAsync(variable))
            .IsSuccessStatusCode;

        public async Task<bool> DeleteSingleScopedConfigurationVariable(string variableName) => (await GetVariablesApiClient($"scoped/single/{variableName}")
            .DeleteAsync())
            .IsSuccessStatusCode;
    }
}
