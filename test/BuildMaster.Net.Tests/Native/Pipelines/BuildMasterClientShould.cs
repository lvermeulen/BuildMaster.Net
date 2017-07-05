using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task Pipelines_GetPipelinesAsync()
        {
            var results = await _client.Pipelines_GetPipelinesAsync().ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
