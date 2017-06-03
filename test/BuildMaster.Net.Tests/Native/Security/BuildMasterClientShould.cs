using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task Security_GetNamedUsersAsync()
        {
            var results = await _client.Security_GetNamedUsersAsync().ConfigureAwait(false);
            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData("Admin")]
        public async Task Security_UserIsNamedAsync(string userName)
        {
            var result = await _client.Security_UserIsNamedAsync(userName, true);
            Assert.True(result);

            result = await _client.Security_UserIsNamedAsync(userName, false);
            Assert.True(result);
        }
    }
}
