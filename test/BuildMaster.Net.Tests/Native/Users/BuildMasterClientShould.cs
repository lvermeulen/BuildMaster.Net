using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task Users_GetGroupsAsync()
        {
            var results = await _client.Users_GetGroupsAsync().ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task Users_GetUsersAsync()
        {
            var result = await _client.Users_GetUsersAsync().ConfigureAwait(false);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Users_SearchUsersAsync()
        {
            var results = await _client.Users_SearchUsersAsync("Admin", null, null, true).ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
