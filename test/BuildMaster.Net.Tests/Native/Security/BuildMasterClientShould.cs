using BuildMaster.Net.Native.Models;
using Xunit;
using Task = System.Threading.Tasks.Task;

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

        [Theory]
        [InlineData(PrincipalTypes.User)]
        [InlineData(PrincipalTypes.Group)]
        public async Task Security_GetPrivilegesAsync(PrincipalTypes principalType)
        {
            var results = await _client.Security_GetPrivilegesAsync(1, principalType).ConfigureAwait(false);
            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task Security_GetRolesAsync()
        {
            var result = await _client.Security_GetRolesAsync(true).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Security_GetTasksAsync()
        {
            var results = await _client.Security_GetTasksAsync().ConfigureAwait(false);
            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
