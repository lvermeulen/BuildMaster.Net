using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task BuildTestResults_GetAllGroupsAsync()
        {
            var results = await _client.BuildTestResults_GetAllGroupsAsync().ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task BuildTestResults_GetTestGroupResultsAsync()
        {
            var results = await _client.BuildTestResults_GetTestGroupResultsAsync(1).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task BuildTestResults_GetTestHistoryAsync()
        {
            var results = await _client.BuildTestResults_GetTestHistoryAsync(null, null, 1, null, 1000).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task BuildTestResults_GetTestLogAsync()
        {
            var results = await _client.BuildTestResults_GetTestLogAsync(1, null).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task BuildTestResults_GetTestResultsAsync()
        {
            var results = await _client.BuildTestResults_GetTestResultsAsync(1, null).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
