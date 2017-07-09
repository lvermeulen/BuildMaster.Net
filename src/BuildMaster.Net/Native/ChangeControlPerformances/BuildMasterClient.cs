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
        /// Gets a summary of the change control performances for a specified change control
        /// </summary>
        public async Task<IEnumerable<ChangeControlPerformanceReleaseSummary>> ChangeControlPerformances_GetReleaseSummaryAsync(int changeControl_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(changeControl_Id).Capitalize(), changeControl_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ChangeControlPerformanceReleaseSummary>>(nameof(ChangeControlPerformances_GetReleaseSummaryAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
