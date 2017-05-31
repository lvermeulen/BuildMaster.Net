using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        private IFlurlClient GetInfrastructureApiClient(string path, object queryParamValues = null) => GetApiClient("/api/infrastructure")
            .AppendPathSegment(path)
            .SetQueryParams(queryParamValues)
            .AllowAnyHttpStatus();
    }
}
