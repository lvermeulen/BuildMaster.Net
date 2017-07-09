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

        public async Task<IEnumerable<Server>> ListServersAsync() => await GetInfrastructureApiClient("servers/list")
            .PostAsync(new StringContent(""))
            .ReceiveJson<IEnumerable<Server>>();

        public async Task<Server> CreateServerAsync(Server server) => await GetInfrastructureApiClient($"servers/create/{server?.Name}")
            .PostJsonAsync(server)
            .ReceiveJson<Server>();

        public async Task<Server> UpdateServerAsync(Server server) => await GetInfrastructureApiClient($"servers/update/{server?.Name}")
            .PostJsonAsync(server)
            .ReceiveJson<Server>();

        public async Task<bool> DeleteServerAsync(Server server)
        {
            var response = await GetInfrastructureApiClient($"servers/delete/{server?.Name}")
                .PostJsonAsync(server);

            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<ServerRole>> ListServerRolesAsync() => await GetInfrastructureApiClient("roles/list")
            .PostAsync(new StringContent(""))
            .ReceiveJson<IEnumerable<ServerRole>>();

        public async Task<ServerRole> CreateServerRoleAsync(ServerRole serverRole) => await GetInfrastructureApiClient($"roles/create/{serverRole?.Name}")
            .PostJsonAsync(serverRole)
            .ReceiveJson<ServerRole>();

        public async Task<ServerRole> UpdateServerRoleAsync(ServerRole serverRole) => await GetInfrastructureApiClient($"roles/update/{serverRole?.Name}")
            .PostJsonAsync(serverRole)
            .ReceiveJson<ServerRole>();

        public async Task<bool> DeleteServerRoleAsync(ServerRole serverRole)
        {
            var response = await GetInfrastructureApiClient($"roles/delete/{serverRole?.Name}")
                .PostJsonAsync(serverRole);

            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Environment>> ListEnvironmentsAsync() => await GetInfrastructureApiClient("environments/list")
            .PostAsync(new StringContent(""))
            .ReceiveJson<IEnumerable<Environment>>();

        public async Task<Environment> CreateEnvironmentsAsync(Environment environment) => await GetInfrastructureApiClient($"environments/create/{environment?.Name}")
            .PostJsonAsync(environment)
            .ReceiveJson<Environment>();

        public async Task<Environment> UpdateEnvironmentsAsync(Environment environment) => await GetInfrastructureApiClient($"environments/update/{environment?.Name}")
            .PostJsonAsync(environment)
            .ReceiveJson<Environment>();

        public async Task<bool> DeleteEnvironmentsAsync(Environment environment)
        {
            var response = await GetInfrastructureApiClient($"environments/delete/{environment?.Name}")
                .PostJsonAsync(environment);

            return response.IsSuccessStatusCode;
        }
    }
}
