using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task Builds_GetBuildsAsync()
        {
            var results = await _client.Builds_GetBuildsAsync(1, null, null, 1000).ConfigureAwait(false);
            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData(3)]
        public async Task Builds_GetExecutionExtendedAsync(int executionId)
        {
            var result = await _client.Builds_GetExecutionExtendedAsync(executionId).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(1, "0.0.1", "1")]
        public async Task Builds_GetExecutionsAsync(int applicationId, string releaseNumber, string buildNumber)
        {
            var results = await _client.Builds_GetExecutionsAsync(applicationId, releaseNumber, buildNumber, null, 1000).ConfigureAwait(false);
            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData(1, "0.0.1", "1")]
        public async Task Builds_GetPromotionsAsync(int applicationId, string releaseNumber, string buildNumber)
        {
            var results = await _client.Builds_GetPromotionsAsync(applicationId, releaseNumber, buildNumber).ConfigureAwait(false);
            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
