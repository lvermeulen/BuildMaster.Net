// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class CredentialsExtended
    {
        public int Credential_Id { get; set; }
        public int Environment_Id { get; set; }
        public string Credential_Name { get; set; }
        public string CredentialType_Name { get; set; }
        public string Configuration_Xml { get; set; }
        public bool AllowFunctionAccess_Indicator { get; set; }
        public string Environment_Name { get; set; }
    }
}
