namespace BuildMaster.Net.Releases.Models
{
    public class GetPackagesRequest
    {
        public int? ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public int? ReleaseId { get; set; }
        public string ReleaseName { get; set; }
        public string ReleaseNumber { get; set; }
        public int? PackageId { get; set; }
        public string PackageNumber { get; set; }
        public int? PipelineId { get; set; }
        public string PipelineName { get; set; }
        public string FurthestStage { get; set; }
        public ReleaseStatuses Status { get; set; }
    }
}
