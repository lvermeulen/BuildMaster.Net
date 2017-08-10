namespace BuildMaster.Net.Releases.Models
{
    public class DeployPackageRequest
    {
        public int? PackageId { get; set; }
        public string PackageNumber { get; set; }
        public int? ReleaseId { get; set; }
        public string ReleaseNumber { get; set; }
        public int? ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string ToStage { get; set; }
        public bool? Force { get; set; }
        public Common.Models.Variables Variables { get; set; }
    }
}
