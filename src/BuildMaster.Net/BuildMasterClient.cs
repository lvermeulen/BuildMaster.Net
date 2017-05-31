using Flurl;

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        private Url GetApiClient(string basePath) => new Url(_url)
            .AppendPathSegment(basePath)
            .SetQueryParam("key", _apiKey);
    }
}
