// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ScriptParameter
    {
        public int Script_Id { get; set; }
        public string Parameter_Name { get; set; }
        public string ParameterType_Code { get; set; }
        public string Description_Text { get; set; }
        public string DefaultValue_Text { get; set; }
    }
}
