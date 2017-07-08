using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task EventListeners_GetEventListenerAsync()
        {
            var result = await _client.EventListeners_GetEventListenerAsync(1).ConfigureAwait(false);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task EventListeners_GetEventListenersAsync()
        {
            var result = await _client.EventListeners_GetEventListenersAsync(null).ConfigureAwait(false);

            Assert.NotNull(result);
        }
    }
}
