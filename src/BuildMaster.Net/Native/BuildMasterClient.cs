using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        private IFlurlClient GetNativeApiClient(string path, object queryParamValues = null) => GetApiClient("/api/json")
            .AppendPathSegment(path)
            .SetQueryParams(queryParamValues)
            .ConfigureClient(settings => settings.OnError = ErrorHandler);

        private async Task<TResult> ExecuteNativeApiMethodAsync<TResult>(string nativeApiMethodName, IDictionary<string, object> parameters = null)
        {
            var response = await GetNativeApiClient(nativeApiMethodName, parameters)
                .GetJsonAsync<TResult>()
                .ConfigureAwait(false);

            return response;
        }

        private async Task<bool> ExecuteNativeApiMethodAsync(string nativeApiMethodName, IDictionary<string, object> parameters = null)
        {
            var response = await GetNativeApiClient(nativeApiMethodName, parameters)
                .GetAsync()
                .ConfigureAwait(false);

            return response.IsSuccessStatusCode;
        }
    }
}
