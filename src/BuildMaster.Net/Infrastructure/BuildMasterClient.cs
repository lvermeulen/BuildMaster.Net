using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BuildMaster.Net.Infrastructure.Models;
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

        public async Task<IEnumerable<Server>> ListServersAsync()
        {
            var response = await GetInfrastructureApiClient("servers/list")
                .PostAsync(new StringContent(""))
                .ReceiveJson<IEnumerable<Server>>();

            return response; //TODO: inline
        }

        public async Task<Server> CreateServerAsync(Server server)
        {
            var response = await GetInfrastructureApiClient($"servers/create/{server?.Name}")
                .PostJsonAsync(server)
                .ReceiveJson<Server>();

            return response; //TODO: inline
        }

        public async Task<Server> UpdateServerAsync(Server server)
        {
            var response = await GetInfrastructureApiClient($"servers/update/{server?.Name}")
                .PostJsonAsync(server)
                .ReceiveJson<Server>();

            return response; //TODO: inline
        }

        public async Task<Server> DeleteServerAsync(Server server)
        {
            var response = await GetInfrastructureApiClient($"servers/delete/{server?.Name}")
                .PostJsonAsync(server)
                .ReceiveJson<Server>();

            return response; //TODO: inline
        }
    }
}
