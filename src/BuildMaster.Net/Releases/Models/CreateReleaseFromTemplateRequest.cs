namespace BuildMaster.Net.Releases.Models
{
    public class CreateReleaseFromTemplateRequest
    {
        public int? ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string ReleaseName { get; set; }
        public string ReleaseNumber { get; set; }
        public string Template { get; set; }
        public Common.Models.Variables Variables { get; set; }
    }
}
