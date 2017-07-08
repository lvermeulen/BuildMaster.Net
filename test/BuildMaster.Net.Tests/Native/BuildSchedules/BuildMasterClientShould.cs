using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        [Fact]
        public async Task BuildSchedules_GetBuildSchedulesAsync()
        {
            var results = await _client.BuildSchedules_GetBuildSchedulesAsync().ConfigureAwait(false);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task BuildSchedules_GetBuildScheduleAsync()
        {
            var result = await _client.BuildSchedules_GetBuildScheduleAsync(1).ConfigureAwait(false);

            Assert.NotNull(result);
        }
    }
}
