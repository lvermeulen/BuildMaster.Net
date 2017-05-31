namespace BuildMaster.Net.Releases.Models
{
    public class RejectReleasePackageRequest
    {
        public int? PackageId { get; set; }
        public string PackageNumber { get; set; }
        public int? ReleaseId { get; set; }
        public string ReleaseNumber { get; set; }
        public int? ApplicationId { get; set; }
        public string ApplicationName { get; set; }
    }
}
