// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildScheduleVariableDefinitionExtended
    {
        public int Schedule_Id { get; set; }
        public int VariableDeclaration_Id { get; set; }
        public string Variable_Name { get; set; }
        public string Scope_Code { get; set; }
        public bool Required_Indicator { get; set; }
        public string DefaultValue_Text { get; set; }
        public string Variable_Configuration { get; set; }
        public string Value_Text { get; set; }
        public int? Application_Id { get; set; }
    }
}
