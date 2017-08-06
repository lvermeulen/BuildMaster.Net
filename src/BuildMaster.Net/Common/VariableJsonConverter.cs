using System;
using System.Collections.Generic;
using System.Linq;
using BuildMaster.Net.Common.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BuildMaster.Net.Common
{
    public class VariableJsonConverter<TResult> : JsonConverter
        where TResult : IList<Variable>, new()
    {
        // ReSharper disable once StaticMemberInGenericType
        private static readonly Type[] s_types = { typeof(Variable), typeof(SensitiveVariable), typeof(ScopedVariable) };

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // intentionally left blank
        }

        private bool TryGetJPropertyNameValue(JProperty property, string name, out string value)
        {
            if (property.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                value = (string)property.Value;
                return true;
            }

            value = null;
            return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var results = new TResult();

            var jobject = JObject.Load(reader);
            foreach (var property in jobject.Children<JProperty>())
            {
                if (property.Value.Type == JTokenType.String)
                {
                    results.Add(new Variable
                    {
                        Name = property.Name,
                        Value = (string)property.Value
                    });
                }
                else if (property.Value.Type == JTokenType.Object)
                {
                    var result = new SensitiveVariable { Name = property.Name };
                    var valueObject = (JObject)property.Value;

                    foreach (var valueProperty in valueObject.Children<JProperty>())
                    {
                        string value;
                        string sensitive;

                        if (TryGetJPropertyNameValue(valueProperty, "value", out value))
                        {
                            result.Value = value;
                        }
                        else if (TryGetJPropertyNameValue(valueProperty, "sensitive", out sensitive))
                        {
                            result.Sensitive = sensitive.ToBool();
                        }
                    }

                    results.Add(result);
                }
            }
        
            return results;
        }

        public override bool CanConvert(Type objectType) => s_types.Any(x => x == objectType);
    }
}
