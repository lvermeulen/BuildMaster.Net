using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task Artifacts_GetArtifactsAsync()
        {
            var results = await _client.Artifacts_GetArtifactsAsync(1, null, null, 0, 1000).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task Artifacts_GetArtifactsByBuildStatusAsync()
        {
            var results = await _client.Artifacts_GetArtifactsByBuildStatusAsync(1, null, null).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
