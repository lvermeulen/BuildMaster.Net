using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task ConfigurationFiles_GetConfigurationFileDeploymentsAsync()
        {
            var results = await _client.ConfigurationFiles_GetConfigurationFileDeploymentsAsync(1, 1, 1, null, 1, 1000).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task ConfigurationFiles_GetConfigurationFileInstancesAsync()
        {
            var results = await _client.ConfigurationFiles_GetConfigurationFileInstancesAsync(1, 1, true).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task ConfigurationFiles_GetConfigurationFilesAsync()
        {
            var result = await _client.ConfigurationFiles_GetConfigurationFilesAsync(1, 1, true, true, true).ConfigureAwait(false);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ConfigurationFiles_GetConfigurationFileVersionAsync()
        {
            var results = await _client.ConfigurationFiles_GetConfigurationFileVersionAsync(1, null, 1).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
