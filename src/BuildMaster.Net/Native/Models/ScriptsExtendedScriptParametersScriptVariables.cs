using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ScriptsExtendedScriptParametersScriptVariables
    {
        public List<ScriptExtended> Scripts_Extended { get; set; }
        public List<ScriptParameter> ScriptParameters { get; set; }
        public List<ScriptVariable> ScriptVariables { get; set; }
    }
}
