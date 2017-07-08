using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task UserConfiguration_GetUserConfigurationAsync()
        {
            var results = await _client.UserConfiguration_GetUserConfigurationAsync("Admin").ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
