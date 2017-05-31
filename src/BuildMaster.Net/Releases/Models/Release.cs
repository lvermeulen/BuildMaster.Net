namespace BuildMaster.Net.Releases.Models
{
    public class Release
    {
        public int Id { get; set; } // An integer representing the system-unique identifier of the release.
        public string Number { get; set; } // A string representing the application-unique identifier of the release.
        public string Name { get; set; } // A string representing the non-unique name or alias for the release.
        public int Sequence { get; set; } // An integer representing the sequence relative to other releases in the application.
        public string Template { get; set; } // A string of the template name used for this release, or null if no template is used.
        public string Status { get; set; } // A string consisting of active, deployed, or canceled.
        public string CreatedBy { get; set; } // A string representing the user who created the release, or SYSTEM if created non-interactively.
        public string CreatedOn { get; set; } // A string representing the UTC date when the release was created, in ISO 8601 format (yyyy-MM-ddThh:mm:ss).
        public string CanceledBy { get; set; } // A string representing the user who canceled the release, or  SYSTEM if created non-interactively.
        public string CanceledOn { get; set; } // A string representing the UTC date when the release was created, in ISO 8601 format(yyyy-MM-ddThh:mm:ss).
        public string TargetDate { get; set; } // A string representing the UTC date of the target release date in ISO 8601 format(yyyy-MM-ddThh:mm:ss).
        public int ApplicationId { get; set; } // An integer representing the system-unique identifier of the application for the release.
        public string ApplicationName { get; set; } // A string representing the system-unique name of the application for the release.
        public int PipelineId { get; set; } // An integer representing the system-unique identifier of the pipeline used by the release.
        public string PipelineName { get; set; } // A string representing the name of the pipeline used by the release.
        public int FurthestPackageId { get; set; } // An integer representing the system-unique identifier of the active or deployed package that has made it furthest in the pipeline for the release.
        public string FurthestPackageNumber { get; set; } // A string representing the application-unique number of the active or deployed package that has made it furthest in the pipeline for the release.
        public int LatestPackageId { get; set; } // An integer representing the system-unique identifier of the active or deployed package that was most recently created.
        public string LatestPackageNumber { get; set; } // A string representing the application-unique number of the active or deployed package that was most recently created.
    }
}
