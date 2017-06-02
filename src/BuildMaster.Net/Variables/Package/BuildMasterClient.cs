using System.Collections.Generic;
using System.Threading.Tasks;
using BuildMaster.Net.Common.Models;
using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        public async Task<IEnumerable<Variable>> GetAllPackageConfigurationVariables(string applicationName, string releaseNumber, string packageNumber)
        {
            var response = await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}/{packageNumber}")
                .GetJsonAsync<IEnumerable<Variable>>();

            return response; //TODO: inline
        }

        public async Task<bool> SetAllPackageConfigurationVariables(string applicationName, string releaseNumber, string packageNumber, IEnumerable<Variable> variables)
        {
            var response = await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}/{packageNumber}")
                .PutJsonAsync(variables);

            return response.IsSuccessStatusCode;
        }

        public async Task<Variable> GetSinglePackageConfigurationVariable(string applicationName, string releaseNumber, string packageNumber, string variableName)
        {
            var response = await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}/{packageNumber}/{variableName}")
                .GetJsonAsync<Variable>();

            return response; //TODO: inline
        }

        public async Task<bool> SetSinglePackageConfigurationVariable(string applicationName, string releaseNumber, string packageNumber, Variable variable)
        {
            var response = await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}/{packageNumber}/{variable?.Name}")
                .PutJsonAsync(variable);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteSinglePackageConfigurationVariable(string applicationName, string releaseNumber, string packageNumber, string variableName)
        {
            var response = await GetVariablesApiClient($"releases/{applicationName}/{releaseNumber}/{packageNumber}/{variableName}")
                .DeleteAsync();

            return response.IsSuccessStatusCode;
        }
    }
}
