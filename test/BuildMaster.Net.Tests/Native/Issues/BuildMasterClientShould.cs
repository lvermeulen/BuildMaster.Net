using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task Issues_GetIssuesAsync()
        {
            var results = await _client.Issues_GetIssuesAsync(1).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task Issues_GetIssueTypesAsync()
        {
            var results = await _client.Issues_GetIssueTypesAsync().ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
