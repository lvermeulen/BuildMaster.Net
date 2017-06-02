﻿// ReSharper disable InconsistentNaming

using Newtonsoft.Json;

namespace BuildMaster.Net.Variables.Models
{
    public enum EntityTypes
    {
        server,
        role,
        application,
        [JsonProperty("application-group")] //TODO: verify EnumConverter
        applicationgroup,
        environment
    }
}