using System.Collections.Generic;
using BuildMaster.Net.Common.Models;
using Newtonsoft.Json.Linq;

namespace BuildMaster.Net.Common
{
    public static class JsonHelper
    {
        //TODO: Json converter for Variables
        //TODO: EnumConverter
        //TODO: Sensitive variables

        public static IEnumerable<Variable> JObjectToVariables(JObject jobject)
        {
            var results = new List<Variable>();

            foreach (var property in jobject.Children<JProperty>())
            {
                results.Add(new Variable
                {
                    Name = property.Name,
                    Value = (string)property.Value
                });
            }

            return results;
        }

        public static IEnumerable<Variable> JsonToVariables(string s) => 
            JObjectToVariables(JObject.Parse(s));
    }
}
