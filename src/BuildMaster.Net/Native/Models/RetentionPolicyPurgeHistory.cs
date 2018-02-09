using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class RetentionPolicyPurgeHistory
    {
        public int RetentionPoliciesPurgeHistoryEntry_Id { get; set; }
        public int Original_RetentionPolicy_Id { get; set; }
        public string Original_RetentionPolicy_Name { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public byte[] LogText_Bytes { get; set; }
    }
}
