using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Theory]
        [InlineData("TestApplication", "0.0.1", "1")]
        public async Task GetAllPackageConfigurationVariables(string applicationName, string releaseNumber, string packageNumber)
        {
            var results = await _client.GetAllPackageConfigurationVariables(applicationName, releaseNumber, packageNumber).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData("TestApplication", "0.0.1", "1", "PackageVariable1")]
        public async Task GetSinglePackageConfigurationVariable(string applicationName, string releaseNumber, string packageNumber, string variableName)
        {
            string result = await _client.GetSinglePackageConfigurationVariable(applicationName, releaseNumber, packageNumber, variableName).ConfigureAwait(false);

            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("TestApplication", "0.0.1", "1", "PackageVariable1")]
        public async Task DeleteSinglePackageConfigurationVariable(string applicationName, string releaseNumber, string packageNumber, string variableName)
        {
            bool result = await _client.DeleteSinglePackageConfigurationVariable(applicationName, releaseNumber, packageNumber, variableName).ConfigureAwait(false);

            Assert.True(result);
        }
    }
}
