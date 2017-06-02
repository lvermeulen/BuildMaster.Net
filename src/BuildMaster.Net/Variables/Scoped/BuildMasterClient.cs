using System.Collections.Generic;
using System.Threading.Tasks;
using BuildMaster.Net.Common.Models;
using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        public async Task<IEnumerable<ScopedVariable>> GetAllScopedConfigurationVariables()
        {
            var response = await GetVariablesApiClient("scoped/all")
                .GetJsonAsync<IEnumerable<ScopedVariable>>();

            return response; //TODO: inline
        }

        public async Task<bool> SetAllScopedConfigurationVariables(IEnumerable<ScopedVariable> variables)
        {
            var response = await GetVariablesApiClient("scoped/all")
                .PutJsonAsync(variables);

            return response.IsSuccessStatusCode;
        }

        public async Task<ScopedVariable> GetSingleScopedConfigurationVariable(string variableName)
        {
            var response = await GetVariablesApiClient($"scoped/single/{variableName}")
                .GetJsonAsync<ScopedVariable>();

            return response; //TODO: inline
        }

        public async Task<bool> SetSingleScopedConfigurationVariable(ScopedVariable variable)
        {
            var response = await GetVariablesApiClient($"scoped/single/{variable?.Name}")
                .PutJsonAsync(variable);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteSingleScopedConfigurationVariable(string variableName)
        {
            var response = await GetVariablesApiClient($"scoped/single/{variableName}")
                .DeleteAsync();

            return response.IsSuccessStatusCode;
        }
    }
}
