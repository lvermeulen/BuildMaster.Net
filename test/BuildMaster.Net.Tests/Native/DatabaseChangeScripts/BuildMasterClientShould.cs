using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task DatabaseChangeScripts_GetChangeScriptsAsync()
        {
            var results = await _client.DatabaseChangeScripts_GetChangeScriptsAsync(1, null, true, 1000).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task DatabaseChangeScripts_GetExecutionAsync()
        {
            var result = await _client.DatabaseChangeScripts_GetExecutionAsync(1).ConfigureAwait(false);

            Assert.NotNull(result);
        }
    }
}
