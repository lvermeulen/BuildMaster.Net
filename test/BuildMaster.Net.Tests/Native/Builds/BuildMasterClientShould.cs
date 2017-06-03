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

        [Fact]
        public async Task Builds_GetExecutionsAsync()
        {
            var results = await _client.Builds_GetExecutionsAsync(1, null, null, null, 1000).ConfigureAwait(false);
            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task Builds_GetPromotionsAsync()
        {
            var results = await _client.Builds_GetPromotionsAsync(1, "0.0.0", null).ConfigureAwait(false);
            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
