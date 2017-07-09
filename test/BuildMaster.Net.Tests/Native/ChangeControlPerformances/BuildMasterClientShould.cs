using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task ChangeControlPerformances_GetReleaseSummaryAsync()
        {
            var results = await _client.ChangeControlPerformances_GetReleaseSummaryAsync(1).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
