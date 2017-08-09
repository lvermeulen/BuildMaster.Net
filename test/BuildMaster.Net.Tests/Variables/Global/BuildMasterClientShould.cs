using System.Threading.Tasks;
using BuildMaster.Net.Common.Models;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task GetAllGlobalConfigurationVariables()
        {
            var results = await _client.GetAllGlobalConfigurationVariables().ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData("TestVariable")]
        public async Task GetSingleGlobalConfigurationVariable(string variableName)
        {
            string result = await _client.GetSingleGlobalConfigurationVariable(variableName).ConfigureAwait(false);

            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("TestVariable")]
        public async Task SetSingleGlobalConfigurationVariable(string variableName)
        {
            bool result = await _client.SetSingleGlobalConfigurationVariable(new Variable { Name = variableName, Value = $"{System.DateTime.UtcNow}" }).ConfigureAwait(false);

            Assert.True(result);
        }

        [Theory]
        [InlineData("TestGlobalVariable")]
        public async Task DeleteSingleGlobalConfigurationVariable(string variableName)
        {
            bool result = await _client.DeleteSingleGlobalConfigurationVariable(variableName).ConfigureAwait(false);

            Assert.True(result);
        }
    }
}
