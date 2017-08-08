﻿using System.Threading.Tasks;
using BuildMaster.Net.Variables.Models;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Theory]
        [InlineData("TestApplicationGroup")]
        public async Task GetAllEntityConfigurationVariables(string entityName)
        {
            var results = await _client.GetAllEntityConfigurationVariables(EntityTypes.applicationgroup, entityName).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData("TestApplicationGroup", "TestApplicationGroupVariable")]
        public async Task GetSingleEntityConfigurationVariable(string entityName, string variableName)
        {
            string result = await _client.GetSingleEntityConfigurationVariable(EntityTypes.applicationgroup, entityName, variableName).ConfigureAwait(false);

            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("TestApplicationGroup", "TestApplicationGroupVariable")]
        public async Task DeleteSingleEntityConfigurationVariable(string entityName, string variableName)
        {
            bool result = await _client.DeleteSingleEntityConfigurationVariable(EntityTypes.applicationgroup, entityName, variableName).ConfigureAwait(false);

            Assert.True(result);
        }
    }
}
