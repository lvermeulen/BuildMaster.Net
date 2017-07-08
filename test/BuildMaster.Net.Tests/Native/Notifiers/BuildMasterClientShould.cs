using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task Notifiers_GetNotifiersAsync()
        {
            var results = await _client.Notifiers_GetNotifiersAsync().ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}
