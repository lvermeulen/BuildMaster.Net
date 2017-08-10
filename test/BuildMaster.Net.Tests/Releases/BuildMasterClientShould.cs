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
        public async Task CreateReleaseAsync()
        {
            var result = await _client.CreateReleaseAsync(new CreateReleaseRequest
            {
                ApplicationName = "TestApplication",
                PipelineName = "TestApplication",
                ReleaseNumber = "0.0.5",
                Variables = new Net.Common.Models.Variables
                {
                    new Net.Common.Models.Variable { Name = "$ReleaseVariable5_1", Value = "ReleaseVariable5_1Value" },
                    new Net.Common.Models.Variable { Name = "$ReleaseVariable5_2", Value = "ReleaseVariable5_2Value" }
                }
            });

            Assert.NotNull(result);
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
