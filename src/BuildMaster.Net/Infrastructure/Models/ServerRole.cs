using System.Collections.Generic;
using BuildMaster.Net.Common.Models;

namespace BuildMaster.Net.Infrastructure.Models
{
    public class ServerRole
    {
        public string Name { get; set; } // same format as server.name
        public List<Variable> Variables { get; set; } // same format as server.variables
    }
}
