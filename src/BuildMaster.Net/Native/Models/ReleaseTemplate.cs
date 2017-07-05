// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ReleaseTemplate
    {
        public int ReleaseTemplate_Id { get; set; }
        public int Application_Id { get; set; }
        public string ReleaseTemplate_Name { get; set; }
        public string ReleaseTemplate_Configuration { get; set; }
    }
}
