using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        private IFlurlClient GetVariablesApiClient(string path, object queryParamValues = null) => GetApiClient("/api/variables")
            .AppendPathSegment(path)
            .SetQueryParams(queryParamValues)
            .AllowAnyHttpStatus();
    }
}
