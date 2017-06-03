using System.Threading.Tasks;
using BuildMaster.Net.Releases.Models;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task GetReleasesAsync()
        {
            var results = await _client.GetReleasesAsync(new GetReleasesRequest()).ConfigureAwait(false);
            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task GetPackagesAsync()
        {
            var results = await _client.GetPackagesAsync(new GetPackagesRequest()).ConfigureAwait(false);
            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task GetDeploymentsAsync()
        {
            var request = new GetDeploymentsRequest
            {
                ApplicationId = 1,
                ReleaseNumber = "0.0.0"
            };
            var results = await _client.GetDeploymentsAsync(request).ConfigureAwait(false);
            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
