namespace BuildMaster.Net.Releases.Models
{
    public class CreateReleasePackageRequest
    {
        public int? ReleaseId { get; set; }
        public string ReleaseNumber { get; set; }
        public int? ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string PackageNumber { get; set; }
        public Common.Models.Variables Variables { get; set; }
    }
}
