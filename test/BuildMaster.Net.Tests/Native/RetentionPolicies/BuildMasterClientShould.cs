using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task RetentionPolicies_GetPurgeHistoryAsync()
        {
            var results = await _client.RetentionPolicies_GetPurgeHistoryAsync(1, 1000).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task RetentionPolicies_GetRetentionPoliciesAsync()
        {
            var results = await _client.RetentionPolicies_GetRetentionPoliciesAsync(null).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
