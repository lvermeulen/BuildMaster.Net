using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task BuildOutputs_GetOutputsAsync()
        {
            var results = await _client.BuildOutputs_GetOutputsAsync(1).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

    }
}
