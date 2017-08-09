using System.ComponentModel;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Variables.Models
{
    public enum EntityTypes
    {
        [Description("server")]
        Server,

        [Description("role")]
        Role,

        [Description("application")]
        Application,

        [Description("application-group")]
        ApplicationGroup,

        [Description("environment")]
        Environment
    }
}
