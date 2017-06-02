using System.Collections.Generic;
using System.Threading.Tasks;
using BuildMaster.Net.Common.Models;
using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        public async Task<IEnumerable<Variable>> GetAllGlobalConfigurationVariables()
        {
            var response = await GetVariablesApiClient("global")
                .GetJsonAsync<IEnumerable<Variable>>();

            return response; //TODO: inline
        }

        public async Task<bool> SetAllGlobalConfigurationVariables(IEnumerable<Variable> variables)
        {
            var response = await GetVariablesApiClient("global")
                .PutJsonAsync(variables);

            return response.IsSuccessStatusCode;
        }

        public async Task<Variable> GetSingleGlobalConfigurationVariable(string variableName)
        {
            var response = await GetVariablesApiClient($"global/{variableName}")
                .GetJsonAsync<Variable>();

            return response; //TODO: inline
        }

        public async Task<bool> SetSingleGlobalConfigurationVariable(Variable variable)
        {
            var response = await GetVariablesApiClient($"global/{variable?.Name}")
                .PutJsonAsync(variable);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteSingleGlobalConfigurationVariable(string variableName)
        {
            var response = await GetVariablesApiClient($"global/{variableName}")
                .DeleteAsync();

            return response.IsSuccessStatusCode;
        }
    }
}
