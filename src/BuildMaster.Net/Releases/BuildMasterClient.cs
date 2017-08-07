using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BuildMaster.Net.Common;
using BuildMaster.Net.Releases.Models;
using Flurl.Http;

// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        private IFlurlClient GetReleasesApiClient(string path, object queryParamValues = null) => GetApiClient("/api/releases")
            .AppendPathSegment(path)
            .SetQueryParams(queryParamValues)
            .ConfigureClient(settings => settings.OnError = ErrorHandler);

        public async Task<IEnumerable<Release>> GetReleasesAsync(GetReleasesRequest request)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(request.ApplicationId).Decapitalize(), request.ApplicationId),
                new NamedValue(nameof(request.ApplicationName).Decapitalize(), request.ApplicationName),
                new NamedValue(nameof(request.ReleaseId).Decapitalize(), request.ReleaseId),
                new NamedValue(nameof(request.ReleaseName).Decapitalize(), request.ReleaseName),
                new NamedValue(nameof(request.ReleaseNumber).Decapitalize(), request.ReleaseNumber),
                new NamedValue(nameof(request.PipelineId).Decapitalize(), request.PipelineId),
                new NamedValue(nameof(request.PipelineName).Decapitalize(), request.PipelineName),
                new NamedValue(nameof(request.Status).Decapitalize(), request.Status.ToString().Decapitalize())
            );

            return await GetReleasesApiClient("", queryParamValues)
                .GetJsonAsync<IEnumerable<Release>>();
        }

        public async Task<Release> CreateReleaseAsync(CreateReleaseRequest request)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(request.ApplicationId).Decapitalize(), request.ApplicationId),
                new NamedValue(nameof(request.ApplicationName).Decapitalize(), request.ApplicationName),
                new NamedValue(nameof(request.ReleaseName).Decapitalize(), request.ReleaseName),
                new NamedValue(nameof(request.ReleaseNumber).Decapitalize(), request.ReleaseNumber),
                new NamedValue(nameof(request.PipelineId).Decapitalize(), request.PipelineId),
                new NamedValue(nameof(request.PipelineName).Decapitalize(), request.PipelineName),
                new NamedValue(nameof(request.Variables).Decapitalize(), request.Variables)
            );

            return await GetReleasesApiClient("create", queryParamValues)
                .PutAsync(new StringContent(""))
                .ReceiveJson<Release>();
        }

        public async Task<Release> CreateReleaseFromTemplateAsync(CreateReleaseFromTemplateRequest request)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(request.ApplicationId).Decapitalize(), request.ApplicationId),
                new NamedValue(nameof(request.ApplicationName).Decapitalize(), request.ApplicationName),
                new NamedValue(nameof(request.ReleaseName).Decapitalize(), request.ReleaseName),
                new NamedValue(nameof(request.ReleaseNumber).Decapitalize(), request.ReleaseNumber),
                new NamedValue(nameof(request.Template).Decapitalize(), request.Template)
                //TODO: Variables
            );

            return await GetReleasesApiClient("create-from-template", queryParamValues)
                .PutAsync(new StringContent(""))
                .ReceiveJson<Release>();
        }

        public async Task<IEnumerable<Package>> GetPackagesAsync(GetPackagesRequest request)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(request.ApplicationId).Decapitalize(), request.ApplicationId),
                new NamedValue(nameof(request.ApplicationName).Decapitalize(), request.ApplicationName),
                new NamedValue(nameof(request.ReleaseId).Decapitalize(), request.ReleaseId),
                new NamedValue(nameof(request.ReleaseName).Decapitalize(), request.ReleaseName),
                new NamedValue(nameof(request.ReleaseNumber).Decapitalize(), request.ReleaseNumber),
                new NamedValue(nameof(request.PackageId).Decapitalize(), request.PackageId),
                new NamedValue(nameof(request.PackageNumber).Decapitalize(), request.PackageNumber),
                new NamedValue(nameof(request.PipelineId).Decapitalize(), request.PipelineId),
                new NamedValue(nameof(request.PipelineName).Decapitalize(), request.PipelineName),
                new NamedValue(nameof(request.FurthestStage).Decapitalize(), request.FurthestStage),
                new NamedValue(nameof(request.Status).Decapitalize(), request.Status.ToString())
            );

            return await GetReleasesApiClient("packages", queryParamValues)
                .GetJsonAsync<IEnumerable<Package>>();
        }

        public async Task<Package> CreateReleasePackageAsync(CreateReleasePackageRequest request)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(request.ReleaseId).Decapitalize(), request.ReleaseId),
                new NamedValue(nameof(request.ReleaseNumber).Decapitalize(), request.ReleaseNumber),
                new NamedValue(nameof(request.ApplicationId).Decapitalize(), request.ApplicationId),
                new NamedValue(nameof(request.ApplicationName).Decapitalize(), request.ApplicationName),
                new NamedValue(nameof(request.PackageNumber).Decapitalize(), request.PackageNumber)
                //TODO: Variables
            );

            return await GetReleasesApiClient("packages/create", queryParamValues)
                .PutAsync(new StringContent(""))
                .ReceiveJson<Package>();
        }

        public async Task<IEnumerable<Deployment>> GetDeploymentsAsync(GetDeploymentsRequest request)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(request.ApplicationId).Decapitalize(), request.ApplicationId),
                new NamedValue(nameof(request.ApplicationName).Decapitalize(), request.ApplicationName),
                new NamedValue(nameof(request.ReleaseId).Decapitalize(), request.ReleaseId),
                new NamedValue(nameof(request.ReleaseName).Decapitalize(), request.ReleaseName),
                new NamedValue(nameof(request.ReleaseNumber).Decapitalize(), request.ReleaseNumber),
                new NamedValue(nameof(request.DeploymentId).Decapitalize(), request.DeploymentId),
                new NamedValue(nameof(request.PipelineStageName).Decapitalize(), request.PipelineStageName),
                new NamedValue(nameof(request.EnvironmentId).Decapitalize(), request.EnvironmentId),
                new NamedValue(nameof(request.EnvironmentName).Decapitalize(), request.EnvironmentName),
                new NamedValue(nameof(request.Status).Decapitalize(), request.Status.ToString())
            );

            return await GetReleasesApiClient("packages/deployments", queryParamValues)
                .GetJsonAsync<IEnumerable<Deployment>>();
        }

        public async Task<Deployment> DeployPackageAsync(DeployPackageRequest request)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(request.PackageId).Decapitalize(), request.PackageId),
                new NamedValue(nameof(request.PackageNumber).Decapitalize(), request.PackageNumber),
                new NamedValue(nameof(request.ReleaseId).Decapitalize(), request.ReleaseId),
                new NamedValue(nameof(request.ReleaseNumber).Decapitalize(), request.ReleaseNumber),
                new NamedValue(nameof(request.ApplicationId).Decapitalize(), request.ApplicationId),
                new NamedValue(nameof(request.ApplicationName).Decapitalize(), request.ApplicationName),
                new NamedValue(nameof(request.ToStage).Decapitalize(), request.ToStage),
                new NamedValue(nameof(request.Force).Decapitalize(), request.Force.ToTrueFalse())
                //TODO: Variables
            );

            return await GetReleasesApiClient("packages/deploy", queryParamValues)
                .PutAsync(new StringContent(""))
                .ReceiveJson<Deployment>();
        }

        public async Task<bool> RejectReleasePackageAsync(RejectReleasePackageRequest request)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(request.PackageId).Decapitalize(), request.PackageId),
                new NamedValue(nameof(request.PackageNumber).Decapitalize(), request.PackageNumber),
                new NamedValue(nameof(request.ReleaseId).Decapitalize(), request.ReleaseId),
                new NamedValue(nameof(request.ReleaseNumber).Decapitalize(), request.ReleaseNumber),
                new NamedValue(nameof(request.ApplicationId).Decapitalize(), request.ApplicationId),
                new NamedValue(nameof(request.ApplicationName).Decapitalize(), request.ApplicationName)
            );

            return (await GetReleasesApiClient("packages/reject", queryParamValues).DeleteAsync())
                .IsSuccessStatusCode;
        }
    }
}
