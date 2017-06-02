using System.Collections.Generic;
using BuildMaster.Net.Common.Models;

namespace BuildMaster.Net.Infrastructure.Models
{
    public class Environment
    {
        public string Name { get; set; } // same format as server.name
        public string ParentName { get; set; } // a string containing the name of the parent environment, or null if there is no parent environment
        public List<Variable> Variables { get; set; } // same format as server.variables
    }
}
