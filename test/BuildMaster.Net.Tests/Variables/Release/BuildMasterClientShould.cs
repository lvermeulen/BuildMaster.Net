using System.Threading.Tasks;
using BuildMaster.Net.Common.Models;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Theory]
        [InlineData("TestApplication", "0.0.3")]
        public async Task GetAllReleaseConfigurationVariables(string applicationName, string releaseNumber)
        {
            var results = await _client.GetAllReleaseConfigurationVariables(applicationName, releaseNumber).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData("TestApplication", "0.0.3", "ReleaseVariableTemp2")]
        public async Task GetSingleReleaseConfigurationVariable(string applicationName, string releaseNumber, string variableName)
        {
            string result = await _client.GetSingleReleaseConfigurationVariable(applicationName, releaseNumber, variableName).ConfigureAwait(false);

            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("TestApplication", "0.0.3", "ReleaseVariableTemp2")]
        public async Task SetSingleReleaseConfigurationVariable(string applicationName, string releaseNumber, string variableName)
        {
            bool result = await _client.SetSingleReleaseConfigurationVariable(applicationName, releaseNumber, new Variable { Name = variableName, Value = $"{System.DateTime.UtcNow}" }).ConfigureAwait(false);

            Assert.True(result);
        }

        [Theory]
        [InlineData("TestApplication", "0.0.3", "ReleaseVariableTemp2")]
        public async Task DeleteSingleReleaseConfigurationVariable(string applicationName, string releaseNumber, string variableName)
        {
            bool result = await _client.DeleteSingleReleaseConfigurationVariable(applicationName, releaseNumber, variableName).ConfigureAwait(false);

            Assert.True(result);
        }
    }
}
