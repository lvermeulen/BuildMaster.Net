namespace BuildMaster.Net.Releases.Models
{
    public class CreateReleaseFromTemplateRequest
    {
        public int? ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string ReleaseName { get; set; }
        public string ReleaseNumber { get; set; }
        public string Template { get; set; }

        //TODO: Variables Optional. Any number of parameters with a key name consisting of a valid variable name prefixed with $, and with any value.
    }
}
