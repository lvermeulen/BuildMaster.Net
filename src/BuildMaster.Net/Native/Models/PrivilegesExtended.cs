// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class PrivilegesExtended
    {
        public int Privilege_Id { get; set; }
        public int UserDirectory_Id { get; set; }
        public string Principal_Name { get; set; }
        public string PrincipalType_Code { get; set; }
        public string PrivilegeType_Code { get; set; }
        public int Role_Id { get; set; }
        public string Role_Name { get; set; }
        public object Application_Id { get; set; }
        public object Application_Name { get; set; }
        public object Environment_Id { get; set; }
        public object Environment_Name { get; set; }
        public object ApplicationGroup_Id { get; set; }
        public object ApplicationGroup_Name { get; set; }
    }
}
