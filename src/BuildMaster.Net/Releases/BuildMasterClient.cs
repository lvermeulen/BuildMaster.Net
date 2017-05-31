﻿using System.Collections.Generic;
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
            .AllowAnyHttpStatus();

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
                new NamedValue(nameof(request.Status).Decapitalize(), request.Status.ToString().Decapitalize()) //TODO: verify Status.ToString()
            );

            //TODO: verify empty path or null
            var response = await GetReleasesApiClient("", queryParamValues)
                .GetJsonAsync<IEnumerable<Release>>();

            //TODO: inline
            return response;
        }

        public async Task<Release> CreateReleaseAsync(CreateReleaseRequest request)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(request.ApplicationId).Decapitalize(), request.ApplicationId),
                new NamedValue(nameof(request.ApplicationName).Decapitalize(), request.ApplicationName),
                new NamedValue(nameof(request.ReleaseName).Decapitalize(), request.ReleaseName),
                new NamedValue(nameof(request.ReleaseNumber).Decapitalize(), request.ReleaseNumber),
                new NamedValue(nameof(request.PipelineId).Decapitalize(), request.PipelineId),
                new NamedValue(nameof(request.PipelineName).Decapitalize(), request.PipelineName)
                //TODO: Variables
            );

            var response = await GetReleasesApiClient("create", queryParamValues)
                .PutAsync(new StringContent(""))
                .ReceiveJson<Release>();

            //TODO: inline
            return response;
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

            var response = await GetReleasesApiClient("create", queryParamValues)
                .PutAsync(new StringContent(""))
                .ReceiveJson<Release>();

            //TODO: inline
            return response;
        }
    }
}