using System.Threading.Tasks;
using BuildMaster.Net.Common.Models;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task GetAllScopedConfigurationVariables()
        {
            var results = await _client.GetAllScopedConfigurationVariables().ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData("SimpleServerVariable")]
        public async Task GetSingleScopedConfigurationVariable(string variableName)
        {
            string result = await _client.GetSingleScopedConfigurationVariable(variableName).ConfigureAwait(false);

            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("SimpleServerVariable")]
        public async Task SetSingleScopedConfigurationVariable(string variableName)
        {
            bool result = await _client.SetSingleScopedConfigurationVariable(new ScopedVariable { Server = "localhost", Name = variableName, Value = $"{System.DateTime.UtcNow}" }).ConfigureAwait(false);

            Assert.True(result);
        }

        [Theory]
        [InlineData("SimpleServerVariable")]
        public async Task DeleteSingleScopedConfigurationVariable(string variableName)
        {
            bool result = await _client.DeleteSingleScopedConfigurationVariable(variableName).ConfigureAwait(false);

            Assert.True(result);
        }
    }
}
