using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class ScriptAsset
    {
        public int ScriptAsset_Id { get; set; }
        public string ScriptAsset_Name { get; set; }
        public int? Application_Id { get; set; }
        public byte[] Script_Text { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public DateTime ModifiedOn_Date { get; set; }
    }
}
