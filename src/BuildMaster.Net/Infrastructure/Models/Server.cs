using System.Collections.Generic;
using BuildMaster.Net.Common.Models;

namespace BuildMaster.Net.Infrastructure.Models
{
    public class Server
    {
        public string Name { get; set; } // A string of no more than fifty characters: numbers(0-9), upper- and lower-case letters(a-Z), dashes(-), and underscores(_); must start with a letter, and may not start or end with a dash or underscore
        public string[] Roles { get; set; } // An array of strings, each consisting of a server role name
        public string[] Environments { get; set; } // An array of strings, each consisting of an environment name
        public string Drift { get; set; } // A string value of reportOnly; this is always ignored by BuildMaster when importing or comparing, and is only used by Otter
        public ServerTypes ServerType { get; set; } // A string value of windows, ssh, powershell, or local
        public string HostName { get; set; } // A string of the hostname of the server; this property is not present when the type is local
        public int? Port { get; set; } // An integer of the port to use of the server; this property is not present when the type is local
        public EncryptionTypes EncryptionType { get; set; } // A string value of aes, ssl, or none; this property is only present when the type is windows
        public string EncryptionKey { get; set; } // A string containing exactly 32 hexidecimal characters; this property is only present when the encryption is aes
        public bool? RequireSsl { get; set; } // A boolean indicating whether to only connect using SSL; this property is only present when the encryption is ssl
        public string CredentialsName { get; set; } // A string containing the name of a resource credential to use; this property is only present when the type is ssh or powershell
        public string TempPath { get; set; } // A string containing the name of the temporary path to use for files; this property is only present when the type is ssh or powershell
        public string WsManUrl { get; set; } // A string containing the WSMan endpoint; this property is only present when the type is powershell
        public bool Active { get; set; } // A boolean indicating whether the server is active or disabled
        public List<Variable> Variables { get; set; } // An object with property/values representing variable names and values
    }
}
