using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task ChangeControls_GetChangeControlPerformancesAsync()
        {
            var results = await _client.ChangeControls_GetChangeControlPerformancesAsync(1, 1, null, true, 1, 1000).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task ChangeControls_GetChangeControlsAsync()
        {
            var result = await _client.ChangeControls_GetChangeControlsAsync(1, null, true, 1000).ConfigureAwait(false);

            Assert.NotNull(result);
        }
    }
}
