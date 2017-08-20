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
        /// Moves an action into a different action group
        /// </summary>
        public async Task<bool> Plans_ChangeActionGroupAsync(
            int deploymentPlanActionGroup_Id,
            int action_Sequence,
            int new_DeploymentPlanActionGroup_Id,
            int new_Action_Sequence)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deploymentPlanActionGroup_Id).Capitalize(), deploymentPlanActionGroup_Id),
                new NamedValue(nameof(action_Sequence).Capitalize(), action_Sequence),
                new NamedValue(nameof(new_DeploymentPlanActionGroup_Id).Capitalize(), new_DeploymentPlanActionGroup_Id),
                new NamedValue(nameof(new_Action_Sequence).Capitalize(), new_Action_Sequence)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Plans_ChangeActionGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Moves a plan action group to the final position of a different deployment plan
        /// </summary>
        public async Task<bool> Plans_ChangeActionGroupDeploymentPlanAsync(
            int deploymentPlanActionGroup_Id,
            int new_DeploymentPlan_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deploymentPlanActionGroup_Id).Capitalize(), deploymentPlanActionGroup_Id),
                new NamedValue(nameof(new_DeploymentPlan_Id).Capitalize(), new_DeploymentPlan_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Plans_ChangeActionGroupDeploymentPlanAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Clones one or more deployment plans
        /// </summary>
        /// <returns>NewDeploymentPlanIdsCsv</returns>
        public async Task<string> Plans_CloneDeploymentPlansAsync(
            string deploymentPlanCloneData_Xml,
            string newDeploymentPlanIdsCsv)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deploymentPlanCloneData_Xml).Capitalize(), deploymentPlanCloneData_Xml),
                new NamedValue(nameof(newDeploymentPlanIdsCsv).Capitalize(), newDeploymentPlanIdsCsv)
            );

            return await ExecuteNativeApiMethodAsync<string>(nameof(Plans_CloneDeploymentPlansAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates an action in the specified action group or updates an existing one
        /// </summary>
        /// <returns>Action_Sequence</returns>
        public async Task<int> Plans_CreateOrUpdateActionAsync(
            int actionGroup_Id,
            int action_Sequence,
            int server_Id,
            string server_Variable_Name,
            string long_Description,
            bool resumeNextOnFailure_Indicator,
            string action_Configuration,
            string short_Description,
            bool active_Indicator,
            int retry_Count,
            bool logFailureAsWarning_Indicator,
            int target_Server_Id,
            string target_Server_Variable_Name,
            int extensionConfiguration_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(actionGroup_Id).Capitalize(), actionGroup_Id),
                new NamedValue(nameof(action_Sequence).Capitalize(), action_Sequence),
                new NamedValue(nameof(server_Id).Capitalize(), server_Id),
                new NamedValue(nameof(server_Variable_Name).Capitalize(), server_Variable_Name),
                new NamedValue(nameof(long_Description).Capitalize(), long_Description),
                new NamedValue(nameof(resumeNextOnFailure_Indicator).Capitalize(), resumeNextOnFailure_Indicator.ToYnIndicator()),
                new NamedValue(nameof(action_Configuration).Capitalize(), action_Configuration),
                new NamedValue(nameof(short_Description).Capitalize(), short_Description),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(retry_Count).Capitalize(), retry_Count),
                new NamedValue(nameof(logFailureAsWarning_Indicator).Capitalize(), logFailureAsWarning_Indicator.ToYnIndicator()),
                new NamedValue(nameof(target_Server_Id).Capitalize(), target_Server_Id),
                new NamedValue(nameof(target_Server_Variable_Name).Capitalize(), target_Server_Variable_Name),
                new NamedValue(nameof(extensionConfiguration_Id).Capitalize(), extensionConfiguration_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Plans_CreateOrUpdateActionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a new deployment plan or changes the name of an existing deployment plan
        /// </summary>
        /// <returns>DeploymentPlan_Id</returns>
        public async Task<int> Plans_CreateOrUpdateDeploymentPlanAsync(
            string deploymentPlan_Name,
            bool allowLocalChanges_Indicator,
            int application_Id,
            int deploymentPlan_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deploymentPlan_Name).Capitalize(), deploymentPlan_Name),
                new NamedValue(nameof(allowLocalChanges_Indicator).Capitalize(), allowLocalChanges_Indicator.ToYnIndicator()),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(deploymentPlan_Id).Capitalize(), deploymentPlan_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Plans_CreateOrUpdateDeploymentPlanAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a new OtterScript deployment plan
        /// </summary>
        /// <returns>Plan_Id</returns>
        public async Task<int> Plans_CreatePlanAsync(
            string plan_Name,
            int application_Id,
            int environment_Id,
            string planType_Code,
            byte[] plan_Bytes,
            int plan_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(plan_Name).Capitalize(), plan_Name),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(environment_Id).Capitalize(), environment_Id),
                new NamedValue(nameof(planType_Code).Capitalize(), planType_Code),
                new NamedValue(nameof(plan_Bytes).Capitalize(), plan_Bytes),
                new NamedValue(nameof(plan_Id).Capitalize(), plan_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Plans_CreatePlanAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes an action from an action group
        /// </summary>
        public async Task<bool> Plans_DeleteActionAsync(
            int deploymentPlanActionGroup_Id,
            int action_Sequence)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deploymentPlanActionGroup_Id).Capitalize(), deploymentPlanActionGroup_Id),
                new NamedValue(nameof(action_Sequence).Capitalize(), action_Sequence)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Plans_DeleteActionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a deployment plan
        /// </summary>
        public async Task<bool> Plans_DeleteDeploymentPlanAsync(int deploymentPlan_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deploymentPlan_Id).Capitalize(), deploymentPlan_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Plans_DeleteDeploymentPlanAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified action group
        /// </summary>
        public async Task<bool> Plans_DeleteDeploymentPlanActionGroupAsync(int deploymentPlanActionGroup_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deploymentPlanActionGroup_Id).Capitalize(), deploymentPlanActionGroup_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Plans_DeleteDeploymentPlanActionGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes an OtterScript plan
        /// </summary>
        public async Task<bool> Plans_DeletePlanAsync(int plan_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(plan_Id).Capitalize(), plan_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Plans_DeletePlanAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of the specified action
        /// </summary>
        public async Task<ActionGroupActionExtended> Plans_GetActionAsync(
            int actionGroup_Id,
            int action_Sequence)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(actionGroup_Id).Capitalize(), actionGroup_Id),
                new NamedValue(nameof(action_Sequence).Capitalize(), action_Sequence)
            );

            return await ExecuteNativeApiMethodAsync<ActionGroupActionExtended>(nameof(Plans_GetActionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of the specified plan, and all the actions associated with the plan
        /// </summary>
        public async Task<ActionGroupsActionGroupActionsExtendedActionGroupUsageSlim> Plans_GetActionGroupAsync(int actionGroup_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(actionGroup_Id).Capitalize(), actionGroup_Id)
            );

            return await ExecuteNativeApiMethodAsync<ActionGroupsActionGroupActionsExtendedActionGroupUsageSlim>(nameof(Plans_GetActionGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all action groups
        /// </summary>
        public async Task<IEnumerable<ActionGroup>> Plans_GetActionGroupsAsync() => 
            await ExecuteNativeApiMethodAsync<IEnumerable<ActionGroup>>(nameof(Plans_GetActionGroupsAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

        /// <summary>
        /// Returns action groups and actions for a deployment plan
        /// </summary>
        public async Task<DeploymentPlansApplicationDeploymentPlansDeploymentPlanActionGroupsExtendedActionGroupActionsExtended> Plans_GetDeploymentPlanAsync(
            int deploymentPlan_Id,
            bool includeActionUsage_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deploymentPlan_Id).Capitalize(), deploymentPlan_Id),
                new NamedValue(nameof(includeActionUsage_Indicator).Capitalize(), includeActionUsage_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<DeploymentPlansApplicationDeploymentPlansDeploymentPlanActionGroupsExtendedActionGroupActionsExtended>(nameof(Plans_GetDeploymentPlanAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of the specified plan, and all the actions associated with the plan
        /// </summary>
        public async Task<DeploymentPlanActionGroupOutput> Plans_GetDeploymentPlanActionGroupAsync(int deploymentPlanActionGroup_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deploymentPlanActionGroup_Id).Capitalize(), deploymentPlanActionGroup_Id)
            );

            return await ExecuteNativeApiMethodAsync<DeploymentPlanActionGroupOutput>(nameof(Plans_GetDeploymentPlanActionGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the deployment plans in the system
        /// </summary>
        public async Task<DeploymentPlansApplicationDeploymentPlans> Plans_GetDeploymentPlansAsync(bool includeAnonymous_Indicator = true)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(includeAnonymous_Indicator).Capitalize(), includeAnonymous_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<DeploymentPlansApplicationDeploymentPlans>(nameof(Plans_GetDeploymentPlansAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns named deployment plans and optionally plans orphaned
        /// </summary>
        public async Task<IEnumerable<DeploymentPlan>> Plans_GetGlobalDeploymentPlansAsync() => 
            await ExecuteNativeApiMethodAsync<IEnumerable<DeploymentPlan>>(nameof(Plans_GetGlobalDeploymentPlansAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

        /// <summary>
        /// Returns the specified OtterScript plan
        /// </summary>
        public async Task<PlanExtended> Plans_GetPlanAsync(int plan_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(plan_Id).Capitalize(), plan_Id)
            );

            return await ExecuteNativeApiMethodAsync<PlanExtended>(nameof(Plans_GetPlanAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the plan which has the specified name and type that is visible to the specified application
        /// </summary>
        public async Task<PlanExtended> Plans_GetPlanByNameAsync(
            int application_Id,
            string plan_Name,
            string planType_Code)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(plan_Name).Capitalize(), plan_Name),
                new NamedValue(nameof(planType_Code).Capitalize(), planType_Code)
            );

            return await ExecuteNativeApiMethodAsync<PlanExtended>(nameof(Plans_GetPlanByNameAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns all OtterScript plans of the specified type which are visible to the specified application
        /// </summary>
        public async Task<IEnumerable<PlanExtended>> Plans_GetPlansAsync(
            int application_Id,
            string planType_Code)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(planType_Code).Capitalize(), planType_Code)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<PlanExtended>>(nameof(Plans_GetPlansAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all plans in the system with the specified name and type
        /// </summary>
        public async Task<IEnumerable<PlanExtended>> Plans_GetPlansByNameAsync(
            string plan_Name,
            string planType_Code)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(plan_Name).Capitalize(), plan_Name),
                new NamedValue(nameof(planType_Code).Capitalize(), planType_Code)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<PlanExtended>>(nameof(Plans_GetPlansByNameAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Changes the sequence of an action within a plan
        /// </summary>
        public async Task<bool> Plans_ResequenceActionAsync(
            int deploymentPlanActionGroup_Id,
            int action_Sequence,
            int new_Action_Sequence)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deploymentPlanActionGroup_Id).Capitalize(), deploymentPlanActionGroup_Id),
                new NamedValue(nameof(action_Sequence).Capitalize(), action_Sequence),
                new NamedValue(nameof(new_Action_Sequence).Capitalize(), new_Action_Sequence)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Plans_ResequenceActionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Changes the sequence of a deployment plan action group
        /// </summary>
        public async Task<bool> Plans_ResequenceActionGroupAsync(
            int deploymentPlanActionGroup_Id,
            int new_DeploymentPlanActionGroup_Sequence)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deploymentPlanActionGroup_Id).Capitalize(), deploymentPlanActionGroup_Id),
                new NamedValue(nameof(new_DeploymentPlanActionGroup_Sequence).Capitalize(), new_DeploymentPlanActionGroup_Sequence)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Plans_ResequenceActionGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified action group
        /// </summary>
        public async Task<bool> Plans_UpdateActionGroupAsync(
            int actionGroup_Id,
            string actionGroup_Name,
            string actionGroup_Description,
            string predicate_Configuration,
            int server_Id,
            string server_Variable_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(actionGroup_Id).Capitalize(), actionGroup_Id),
                new NamedValue(nameof(actionGroup_Name).Capitalize(), actionGroup_Name),
                new NamedValue(nameof(actionGroup_Description).Capitalize(), actionGroup_Description),
                new NamedValue(nameof(predicate_Configuration).Capitalize(), predicate_Configuration),
                new NamedValue(nameof(server_Id).Capitalize(), server_Id),
                new NamedValue(nameof(server_Variable_Name).Capitalize(), server_Variable_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Plans_UpdateActionGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified deployment plan action group
        /// </summary>
        public async Task<bool> Plans_UpdateDeploymentPlanActionGroupAsync(
            int deploymentPlanActionGroup_Id,
            bool active_Indicator,
            string actionGroup_Name,
            string actionGroup_Description,
            string predicate_Configuration,
            int server_Id,
            string server_Variable_Name,
            string deployable_Name,
            int deployable_Application_Id,
            bool iterate_Servers_Indicator,
            bool iterate_Deployables_Indicator,
            bool parallel_Indicator,
            int onSuccess_DeploymentPlanActionGroup_Id,
            int onFailure_DeploymentPlanActionGroup_Id,
            bool onFailure_Continue_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(deploymentPlanActionGroup_Id).Capitalize(), deploymentPlanActionGroup_Id),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(actionGroup_Name).Capitalize(), actionGroup_Name),
                new NamedValue(nameof(actionGroup_Description).Capitalize(), actionGroup_Description),
                new NamedValue(nameof(predicate_Configuration).Capitalize(), predicate_Configuration),
                new NamedValue(nameof(server_Id).Capitalize(), server_Id),
                new NamedValue(nameof(server_Variable_Name).Capitalize(), server_Variable_Name),
                new NamedValue(nameof(deployable_Name).Capitalize(), deployable_Name),
                new NamedValue(nameof(deployable_Application_Id).Capitalize(), deployable_Application_Id),
                new NamedValue(nameof(iterate_Servers_Indicator).Capitalize(), iterate_Servers_Indicator.ToYnIndicator()),
                new NamedValue(nameof(iterate_Deployables_Indicator).Capitalize(), iterate_Deployables_Indicator.ToYnIndicator()),
                new NamedValue(nameof(parallel_Indicator).Capitalize(), parallel_Indicator.ToYnIndicator()),
                new NamedValue(nameof(onSuccess_DeploymentPlanActionGroup_Id).Capitalize(), onSuccess_DeploymentPlanActionGroup_Id),
                new NamedValue(nameof(onFailure_DeploymentPlanActionGroup_Id).Capitalize(), onFailure_DeploymentPlanActionGroup_Id),
                new NamedValue(nameof(onFailure_Continue_Indicator).Capitalize(), onFailure_Continue_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync(nameof(Plans_UpdateDeploymentPlanActionGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates an OtterScript deployment plan
        /// </summary>
        public async Task<bool> Plans_UpdatePlanAsync(
            int plan_Id,
            string plan_Name,
            byte[] plan_Bytes,
            int environment_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(plan_Id).Capitalize(), plan_Id),
                new NamedValue(nameof(plan_Name).Capitalize(), plan_Name),
                new NamedValue(nameof(plan_Bytes).Capitalize(), plan_Bytes),
                new NamedValue(nameof(environment_Id).Capitalize(), environment_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Plans_UpdatePlanAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
