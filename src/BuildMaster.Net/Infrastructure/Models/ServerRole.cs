using System.Collections.Generic;
using BuildMaster.Net.Common;
using BuildMaster.Net.Common.Models;
using Newtonsoft.Json;

namespace BuildMaster.Net.Infrastructure.Models
{
    public class ServerRole
    {
        public string Name { get; set; } // same format as server.name
        [JsonConverter(typeof(VariableJsonConverter<List<Variable>>))]
        public List<Variable> Variables { get; set; } // same format as server.variables
    }
}
