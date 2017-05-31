using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        private IFlurlClient GetReleasesApiClient(string path, object queryParamValues = null) => GetApiClient("/api/releases")
            .AppendPathSegment(path)
            .SetQueryParams(queryParamValues)
            .AllowAnyHttpStatus();
    }
}
