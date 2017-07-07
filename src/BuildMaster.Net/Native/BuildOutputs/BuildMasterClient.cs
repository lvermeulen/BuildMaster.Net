using System.Collections.Generic;
using System.Threading.Tasks;
using BuildMaster.Net.Common;
using BuildMaster.Net.Native.Models;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        /// <summary>
        /// Adds a build output report to a specified build execution
        /// </summary>
        public async Task<bool> BuildOutputs_AddOutputAsync(
            int execution_Id,
            string output_Name,
            byte[] output_Bytes,
            string outputType_Code)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id),
                new NamedValue(nameof(output_Name).Capitalize(), output_Name),
                new NamedValue(nameof(output_Bytes).Capitalize(), output_Bytes),
                new NamedValue(nameof(outputType_Code).Capitalize(), outputType_Code)
            );

            return await ExecuteNativeApiMethodAsync(nameof(BuildOutputs_AddOutputAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the build output report for a specified build and sequence number
        /// </summary>
        public async Task<BuildOutputExtended> BuildOutputs_GetOutputAsync(
            int execution_Id,
            int output_Sequence)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id),
                new NamedValue(nameof(output_Sequence).Capitalize(), output_Sequence)
            );

            return await ExecuteNativeApiMethodAsync<BuildOutputExtended>(nameof(BuildOutputs_GetOutputAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the build output reports for a specified build
        /// </summary>
        public async Task<IEnumerable<BuildOutputExtended>> BuildOutputs_GetOutputsAsync(int execution_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BuildOutputExtended>>(nameof(BuildOutputs_GetOutputsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
