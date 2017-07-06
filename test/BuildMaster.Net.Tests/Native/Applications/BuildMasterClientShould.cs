using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task Applications_GetApplicationsAsync()
        {
            var results = await _client.Applications_GetApplicationsAsync().ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task Applications_SearchApplicationsAsync()
        {
            var results = await _client.Applications_SearchApplicationsAsync("Test").ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task Applications_GetApplicationAsync()
        {
            var result = await _client.Applications_GetApplicationAsync(1).ConfigureAwait(false);

            Assert.NotNull(result);
        }
    }
}
