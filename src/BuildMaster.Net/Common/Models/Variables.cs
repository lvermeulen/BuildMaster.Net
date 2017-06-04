using System.Collections.Generic;
using Newtonsoft.Json;

namespace BuildMaster.Net.Common.Models
{
    [JsonConverter(typeof(VariableJsonConverter<Variables>))]
    public class Variables : List<Variable>
    { }
}
