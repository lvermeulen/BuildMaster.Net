using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task Scripts_GetScriptAsync()
        {
            var result = await _client.Scripts_GetScriptAsync(1).ConfigureAwait(false);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Scripts_GetScriptsAsync()
        {
            var results = await _client.Scripts_GetScriptsAsync().ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
