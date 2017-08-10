namespace BuildMaster.Net.Releases.Models
{
    public class CreateReleaseRequest
    {
        public int? ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string ReleaseName { get; set; }
        public string ReleaseNumber { get; set; }
        public int? PipelineId { get; set; }
        public string PipelineName { get; set; }
        public Common.Models.Variables Variables { get; set; }
    }
}
