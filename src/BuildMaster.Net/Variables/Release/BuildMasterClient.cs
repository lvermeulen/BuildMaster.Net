using System.Collections.Generic;
using System.Threading.Tasks;
using BuildMaster.Net.Common.Models;
using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        public async Task<IEnumerable<Variable>> GetAllReleaseConfigurationVariables(string applicationName, string releaseNumber)
        {
            var response = await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}")
                .GetJsonAsync<IEnumerable<Variable>>();

            return response; //TODO: inline
        }

        public async Task<bool> SetAllReleaseConfigurationVariables(string applicationName, string releaseNumber, IEnumerable<Variable> variables)
        {
            var response = await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}")
                .PutJsonAsync(variables);

            return response.IsSuccessStatusCode;
        }

        public async Task<Variable> GetSingleReleaseConfigurationVariable(string applicationName, string releaseNumber, string variableName)
        {
            var response = await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}/{variableName}")
                .GetJsonAsync<Variable>();

            return response; //TODO: inline
        }

        public async Task<bool> SetSingleReleaseConfigurationVariable(string applicationName, string releaseNumber, Variable variable)
        {
            var response = await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}/{variable?.Name}")
                .PutJsonAsync(variable);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteSingleReleaseConfigurationVariable(string applicationName, string releaseNumber, string variableName)
        {
            var response = await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}/{variableName}")
                .DeleteAsync();

            return response.IsSuccessStatusCode;
        }
    }
}
