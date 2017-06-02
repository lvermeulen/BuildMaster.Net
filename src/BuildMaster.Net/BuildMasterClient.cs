using Flurl;

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        private readonly string _url;
        private readonly string _apiKey;

        public BuildMasterClient(string url, string apiKey)
        {
            _url = url;
            _apiKey = apiKey;
        }

        private Url GetApiClient(string basePath) => new Url(_url)
            .AppendPathSegment(basePath)
            .SetQueryParam("key", _apiKey);
    }
}
