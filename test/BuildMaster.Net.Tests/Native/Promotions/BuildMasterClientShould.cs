using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task Promotions_GetApprovalsReceivedAsync()
        {
            var results = await _client.Promotions_GetApprovalsReceivedAsync(1, "0.0.1", null, null, 0).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task Promotions_GetScheduledAsync()
        {
            var results = await _client.Promotions_GetScheduledAsync(1, "0.0.1", null, null, null).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
