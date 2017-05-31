namespace BuildMaster.Net.Releases.Models
{
    public class Deployment
    {
        public int Id { get; set; } // An integer representing the system-unique identifier of the deployment.
        public string Plan { get; set; } // A string representing the name of the plan used for deployment.
        public string Status { get; set; } // A string consisting of pending, executing, succeeded, warned, or failed
        public string Started { get; set; } // A string representing the UTC date when the deployment actually started, in ISO 8601 format(yyyy-MM-ddThh:mm:ss), or null if the execution hasn't started.
        public string Ended { get; set; } // A string representing the UTC date when the deployment completed, in ISO 8601 format(yyyy-MM-ddThh:mm:ss), or null if the execution hasn't completed.
        public string CreatedBy { get; set; } // A string representing the user who initiated the deployment, or  SYSTEM if initiated non-interactively.
        public string CreatedOn { get; set; } // A string representing the UTC date when the deployment was initiated, in ISO 8601 format(yyyy-MM-ddThh:mm:ss).
        public string CanceledBy { get; set; } // A string representing the user who canceled the deployment(SYSTEM if canceled non-interactively), or null if the deployment was not canceled.
        public string CanceledOn { get; set; } // A string representing the UTC date when the deployment was canceled, in ISO 8601 format(yyyy-MM-ddThh:mm:ss), or null if the deployment was not canceled.
        public int PipelineId { get; set; } // An integer representing the system-unique identifier of the pipeline used by the deployment.
        public string PipelineName { get; set; } // A string representing the name of the pipeline used by the deployment.
        public string PipelineStageName { get; set; } // A string representing the name the stage in the pipeline used by the deployment.
        public int EnvironmentId { get; set; } // An integer representing the system-unique identifier of the environment used by the deployment, or null if no environment is in context.
        public string EnvironmentName { get; set; } // A string representing the name of the environment used by the deployment, or null if no environment is in context.
        public int ApplicationId { get; set; } // An integer representing the system-unique identifier of the application for the deployment.
        public string ApplicationName { get; set; } // A string representing the system-unique name of the application for the deployment.
        public int ReleaseId { get; set; } // An integer representing the system-unique identifier of the release for the deployment.
        public int ReleaseNumber { get; set; } // A string representing the application-unique number of the release for the deployment.
        public string ReleaseName { get; set; } // A string representing the name of the release for the deployment.
        public int PackageId { get; set; } // An integer representing the system-unique identifier of the package for the deployment.
        public string PackageNumber { get; set; } // A string representing the release-unique number of the package for the deployment.
    }
}
