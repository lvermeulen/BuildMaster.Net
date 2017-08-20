using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Theory]
        [InlineData(3)]
        public async Task BuildOutputs_GetOutputsAsync(int executionId)
        {
            var results = await _client.BuildOutputs_GetOutputsAsync(executionId).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
