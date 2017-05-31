namespace BuildMaster.Net.Releases.Models
{
    public class GetReleasesRequest
    {
        public int? ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public int? ReleaseId { get; set; }
        public string ReleaseName { get; set; }
        public string ReleaseNumber { get; set; }
        public int? PipelineId { get; set; }
        public string PipelineName { get; set; }
        public ReleaseStatuses Status { get; set; }
    }
}
