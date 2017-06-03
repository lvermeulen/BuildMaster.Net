using BuildMaster.Net.Infrastructure.Models;
using Newtonsoft.Json;
using Xunit;

namespace BuildMaster.Net.Tests.Common
{
    public class VariableJsonConverterShould
    {
        [Fact]
        public void ConvertEmptyServerVariables()
        {
            const string JSON = @"{""active"":true,""environments"":[""Integration"",""Testing"",""Production""],""roles"":[],""serverType"":""local"",""drift"":""reportOnly"",""name"":""localhost"",""variables"":{}}";

            var server = JsonConvert.DeserializeObject<Server>(JSON);
            Assert.NotNull(server);
            Assert.NotNull(server.Variables);
        }
        [Fact]
        public void ConvertServerVariables()
        {
            const string JSON = @"{""active"":true,""environments"":[""Integration"",""Testing"",""Production""],""roles"":[""TestServerRole""],""serverType"":""local"",""drift"":""reportOnly"",""name"":""localhost"",""variables"":{""SimpleServerVariable"":""SimpleServerVariableValue"",""SimpleSensitiveServerVariable"":{""value"":""SimpleSensitiveServerVariableValue"",""sensitive"":true}}}";

            var server = JsonConvert.DeserializeObject<Server>(JSON);
            Assert.NotNull(server);
            Assert.NotNull(server.Variables);
            Assert.NotEmpty(server.Variables);
        }
    }
}

