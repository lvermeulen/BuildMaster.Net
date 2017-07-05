using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task Plans_GetDeploymentPlansAsync()
        {
            var result = await _client.Plans_GetDeploymentPlansAsync().ConfigureAwait(false);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Plans_GetPlansAsync()
        {
            var results = await _client.Plans_GetPlansAsync(1, null).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
