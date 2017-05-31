namespace BuildMaster.Net.Releases.Models
{
    public class CreateReleasePackageRequest
    {
        public int? ReleaseId { get; set; }
        public string ReleaseNumber { get; set; }
        public int? ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string PackageNumber { get; set; }

        //TODO: Variables Optional. Any number of parameters with a key name consisting of a valid variable name prefixed with $, and with any value.
    }
}
