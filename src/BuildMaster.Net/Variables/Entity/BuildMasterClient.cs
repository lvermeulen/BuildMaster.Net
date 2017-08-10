using System.Collections.Generic;
using System.Threading.Tasks;
using BuildMaster.Net.Common;
using BuildMaster.Net.Common.Models;
using BuildMaster.Net.Variables.Models;
using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        public async Task<Common.Models.Variables> GetAllEntityConfigurationVariables(EntityTypes entityType, string entityName) => await GetVariablesApiClient($"{entityType}/{entityName}")
            .GetJsonAsync<Common.Models.Variables>();

        public async Task<bool> SetAllEntityConfigurationVariables(EntityTypes entityType, string entityName, IEnumerable<Variable> variables) => (await GetVariablesApiClient($"{entityType}/{entityName}")
            .PutJsonAsync(variables))
            .IsSuccessStatusCode;

        public async Task<string> GetSingleEntityConfigurationVariable(EntityTypes entityType, string entityName, string variableName) => await GetVariablesApiClient($"{entityType}/{entityName}/{variableName}")
            .GetStringAsync();

        public async Task<bool> SetSingleEntityConfigurationVariable(EntityTypes entityType, string entityName, Variable variable) => (await GetVariablesApiClient($"{EnumExtensions.GetEnumDescription(entityType)}/{entityName}/{variable?.Name}")
            .PutStringAsync(variable?.Value))
            .IsSuccessStatusCode;

        public async Task<bool> DeleteSingleEntityConfigurationVariable(EntityTypes entityType, string entityName, string variableName) => (await GetVariablesApiClient($"{entityType}/{entityName}/{variableName}")
            .DeleteAsync())
            .IsSuccessStatusCode;
    }
}
