using System.Threading.Tasks;
using Xunit;

namespace BuildMaster.Net.Tests
{
    public class BuildMasterClientShould
    {
        private readonly BuildMasterClient _client;

        public BuildMasterClientShould()
        {
            _client = new BuildMasterClient("", "");
        }

        [Fact]
        public async Task Security_GetNamedUsersAsync()
        {
            var results = await _client.Security_GetNamedUsersAsync().ConfigureAwait(false);
            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
