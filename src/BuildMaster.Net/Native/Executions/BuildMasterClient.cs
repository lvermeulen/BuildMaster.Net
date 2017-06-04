using System.Threading.Tasks;
using BuildMaster.Net.Common;
using BuildMaster.Net.Native.Models;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        /// <summary>
        /// Gets a manual execution
        /// </summary>
        public async Task<ManualExecutionsExtended> Executions_GetManualExecutionAsync(int execution_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id)
            );

            return await ExecuteNativeApiMethodAsync<ManualExecutionsExtended>(nameof(Executions_GetManualExecutionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
