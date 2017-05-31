namespace BuildMaster.Net.Releases.Models
{
    public class GetDeploymentsRequest
    {
        public int? ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public int? ReleaseId { get; set; }
        public string ReleaseName { get; set; }
        public string ReleaseNumber { get; set; }
        public int? DeploymentId { get; set; }
        public string PipelineStageName { get; set; }
        public int? EnvironmentId { get; set; }
        public string EnvironmentName { get; set; }
        public DeploymentStatuses Status { get; set; }
    }
}
