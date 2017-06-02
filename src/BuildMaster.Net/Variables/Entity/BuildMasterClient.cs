﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BuildMaster.Net.Common.Models;
using BuildMaster.Net.Variables.Models;
using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        public async Task<IEnumerable<Variable>> GetAllEntityConfigurationVariables(EntityTypes entityType, string entityName)
        {
            var response = await GetVariablesApiClient($"{entityType}/{entityName}")
                .GetJsonAsync<IEnumerable<Variable>>();

            return response; //TODO: inline
        }

        public async Task<bool> SetAllEntityConfigurationVariables(EntityTypes entityType, string entityName, IEnumerable<Variable> variables)
        {
            var response = await GetVariablesApiClient($"{entityType}/{entityName}")
                .PutJsonAsync(variables);

            return response.IsSuccessStatusCode;
        }

        public async Task<Variable> GetSingleEntityConfigurationVariable(EntityTypes entityType, string entityName, string variableName)
        {
            var response = await GetVariablesApiClient($"{entityType}/{entityName}/{variableName}")
                .GetJsonAsync<Variable>();

            return response; //TODO: inline
        }

        public async Task<bool> SetSingleEntityConfigurationVariable(EntityTypes entityType, string entityName, Variable variable)
        {
            var response = await GetVariablesApiClient($"{entityType}/{entityName}/{variable?.Name}")
                .PutJsonAsync(variable);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteSingleEntityConfigurationVariable(EntityTypes entityType, string entityName, string variableName)
        {
            var response = await GetVariablesApiClient($"{entityType}/{entityName}/{variableName}")
                .DeleteAsync();

            return response.IsSuccessStatusCode;
        }
    }
}