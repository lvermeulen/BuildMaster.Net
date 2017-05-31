namespace BuildMaster.Net.Releases.Models
{
    public class Package
    {
        public int Id { get; set; } // An integer representing the system-unique identifier of the package.
        public string Number { get; set; } // A string representing the release-unique identifier of the package.
        public string Status { get; set; } // A string consisting of active, deployed, or rejected.
        public string CreatedBy { get; set; } // A string representing the user who created the package, or SYSTEM if created non-interactively.
        public string CreatedOn { get; set; } // A string representing the UTC date when the package was created, in ISO 8601 format(yyyy-MM-ddThh:mm:ss).
        public string RejectedBy { get; set; } // A string representing the user who rejected the package, or SYSTEM if rejected non-interactively.
        public string RejectedOn { get; set; } // A string representing the UTC date when the package was rejected, in ISO 8601 format(yyyy-MM-ddThh:mm:ss).
        public int PipelineId { get; set; } // An integer representing the system-unique identifier of the pipeline used by the package.
        public string PipelineName { get; set; } // A string representing the name of the pipeline used by the package.
        public string FurthestStage { get; set; } // A string representing the name the furthest stage the package has advanced to in the pipeline.
        public int ApplicationId { get; set; } // An integer representing the system-unique identifier of the application for the package.
        public string ApplicationName { get; set; } // A string representing the system-unique name of the application for the package.
        public int ReleaseId { get; set; } // An integer representing the system-unique identifier of the release for the package.
        public string ReleaseNumber { get; set; } // A string representing the application-unique number of the release for the package.
        public string ReleaseName { get; set; } // A string representing the name of the release for the package.
    }
}
