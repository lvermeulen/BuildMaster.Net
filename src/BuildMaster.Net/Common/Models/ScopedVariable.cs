using Newtonsoft.Json;

namespace BuildMaster.Net.Common.Models
{
    public class ScopedVariable : SensitiveVariable
    {
        public string Server { get; set; } // A string value of the name of the server the variable is associated with, or null if it's not associated
        public string Role { get; set; } // A string value of the name of the role the variable is associated with, or null if it's not associated
        public string Environment { get; set; } // A string value of the name of the environment the variable is associated with, or null if it's not associated
        public string Application { get; set; } // A string value of the name of the application the variable is associated with, or null if it's not associated
        [JsonProperty("application-group")]
        public string ApplicationGroup { get; set; } // A string value of the name of the application-group the variable is associated with, or null if it's not associated
    }
}
