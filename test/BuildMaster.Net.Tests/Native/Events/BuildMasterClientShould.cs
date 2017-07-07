using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task Events_GetEventOccurrencesAsync()
        {
            var results = await _client.Events_GetEventOccurrencesAsync().ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task Events_GetEventOccurrenceAsync()
        {
            var result = await _client.Events_GetEventOccurrenceAsync(1215).ConfigureAwait(false);

            Assert.NotNull(result);
        }

    }
}
