// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        /*
            AdminEdit_PurgeArtifact
                Purges an artifact from the specified build.
                    Application_Id (Int32)
                    Release_Number (String)
                    Build_Number (String)
                    Artifact_Name (String)	none
            AdminEdit_PurgeBuild
                Purges an entire build and all associated data from the system.
                    Application_Id (Int32)
                    Release_Number (String)
                    Build_Number (String)	none
            AdminEdit_UpdateBuildStatus
                Updates the status of a build.
                    Application_Id (Int32)
                    Release_Number (String)
                    Build_Number (String)
                    BuildStatus_Name (String)	none
            AdminEdit_UpdateExecutionStatus
                Updates the status of an execution.
                    Execution_Id (Int32)
                    ExecutionStatus_Code (String)	none
            AdminEdit_UpdatePromotionStatus
                Updates the status of a promotion.
                    Promotion_Id (Int32)
                    PromotionStatus_Name (String)	none
            AdminEdit_UpdateReleaseStatus
                Updates the status of a release.
                    Application_Id (Int32)
                    Release_Number (String)
                    ReleaseStatus_Name (String)	none
        */
    }
}
