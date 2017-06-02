using System.Linq;
using BuildMaster.Net.Common;
using Xunit;

namespace BuildMaster.Net.Tests.Common
{
    public class JsonHelperShould
    {
        [Fact]
        public void DeserializeVariables()
        {
            const string JSON = @"{
    ""licensekey"": ""value"",
    ""listenports"": ""@(8088,8089,8090)""
}";

            var variables = JsonHelper.JsonToVariables(JSON);
            Assert.NotNull(variables);
            Assert.True(variables.Any());
        }
    }
}
