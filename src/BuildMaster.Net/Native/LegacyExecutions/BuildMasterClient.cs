using System.Threading.Tasks;
using BuildMaster.Net.Common;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        /// <summary>
        /// Creates, updates, or deletes an execution time variable value
        /// </summary>
        public async Task<bool> LegacyExecutions_SetVariableValueAsync(
            int buildExecution_ActionGroupAction_Id,
            string variable_Name,
            string value_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(buildExecution_ActionGroupAction_Id).Capitalize(), buildExecution_ActionGroupAction_Id),
                new NamedValue(nameof(variable_Name).Capitalize(), variable_Name),
                new NamedValue(nameof(value_Text).Capitalize(), value_Text)
            );

            return await ExecuteNativeApiMethodAsync(nameof(LegacyExecutions_SetVariableValueAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
