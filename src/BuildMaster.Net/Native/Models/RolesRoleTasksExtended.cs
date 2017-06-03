using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class RolesRoleTasksExtended
    {
        public List<Role> Roles { get; set; }
        public List<RoleTasksExtended> RoleTasks_Extended { get; set; }
    }
}
