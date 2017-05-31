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
        /// Assigns the specified user as a named user with the specified user class type
        /// </summary>
        public async Task<bool> Security_AddNamedUserAsync(string user_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(user_Name).Capitalize(), user_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Security_AddNamedUserAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Grants or denies the specified principal the ability to perform a certain role
        /// </summary>
        /// <returns>Privilege_Id</returns>
        public async Task<int> Security_AddPrivilegeAsync(
            int privilege_Id,
            int userDirectory_Id,
            string principal_Name,
            string principalType_Code,
            int role_Id,
            int applicationGroup_Id,
            int application_Id,
            int environment_Id,
            string privilegeType_Code)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(privilege_Id).Capitalize(), privilege_Id),
                new NamedValue(nameof(userDirectory_Id).Capitalize(), userDirectory_Id),
                new NamedValue(nameof(principal_Name).Capitalize(), principal_Name),
                new NamedValue(nameof(principalType_Code).Capitalize(), principalType_Code),
                new NamedValue(nameof(role_Id).Capitalize(), role_Id),
                new NamedValue(nameof(applicationGroup_Id).Capitalize(), applicationGroup_Id),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(environment_Id).Capitalize(), environment_Id),
                new NamedValue(nameof(privilegeType_Code).Capitalize(), privilegeType_Code)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Security_AddPrivilegeAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates or updates a role
        /// </summary>
        /// <returns>Role_Id</returns>
        public async Task<int> Security_CreateOrUpdateRoleAsync(
            int role_Id,
            string role_Name,
            string role_Description,
            string tasks_Csv)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(role_Id).Capitalize(), role_Id),
                new NamedValue(nameof(role_Name).Capitalize(), role_Name),
                new NamedValue(nameof(role_Description).Capitalize(), role_Description),
                new NamedValue(nameof(tasks_Csv).Capitalize(), tasks_Csv)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Security_CreateOrUpdateRoleAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified role from the system
        /// </summary>
        public async Task<bool> Security_DeleteRoleAsync(int role_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(role_Id).Capitalize(), role_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Security_DeleteRoleAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified named user
        /// </summary>
        public async Task<NamedUser> Security_GetNamedUserAsync(string user_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(user_Name).Capitalize(), user_Name)
            );

            return await ExecuteNativeApiMethodAsync<NamedUser>(nameof(Security_GetNamedUserAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of the named users in the system
        /// </summary>
        public async Task<IEnumerable<NamedUser>> Security_GetNamedUsersAsync() =>
            await ExecuteNativeApiMethodAsync<IEnumerable<NamedUser>>(nameof(Security_GetNamedUsersAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

        /// <summary>
        /// Gets an anonymous role containing the specified tasks, creating one if necessary
        /// </summary>
        /// <returns>Role_Id</returns>
        public async Task<int> Security_GetOrAddAnonymousRoleAsync(
            string tasks_Csv,
            int role_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(tasks_Csv).Capitalize(), tasks_Csv),
                new NamedValue(nameof(role_Id).Capitalize(), role_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Security_GetOrAddAnonymousRoleAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of privileges assigned in the system
        /// </summary>
        public async Task<IEnumerable<PrivilegesExtended>> Security_GetPrivilegesAsync(
            int userDirectory_Id,
            string principalType_Code)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(userDirectory_Id).Capitalize(), userDirectory_Id),
                new NamedValue(nameof(principalType_Code).Capitalize(), principalType_Code)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<PrivilegesExtended>>(nameof(Security_GetPrivilegesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        //TODO: return (Roles, RoleTasksExtended)
        /// <summary>
        /// Gets the specified role, along with all the tasks that comprise the role
        /// </summary>
        public async Task<IEnumerable<Roles>> Security_GetRoleAsync(int role_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(role_Id).Capitalize(), role_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<Roles>>(nameof(Security_GetRoleAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        //TODO: return (Roles, RoleTasksExtended)
        /// <summary>
        /// Gets all the roles in the system, along with all the tasks comprising each role
        /// </summary>
        public async Task<IEnumerable<Roles>> Security_GetRolesAsync(bool includeAnonymous_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(includeAnonymous_Indicator).Capitalize(), includeAnonymous_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<Roles>>(nameof(Security_GetRolesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all of the tasks in the system
        /// </summary>
        public async Task<IEnumerable<Tasks>> Security_GetTasksAsync()
        {
            return await ExecuteNativeApiMethodAsync<IEnumerable<Tasks>>(nameof(Security_GetTasksAsync).WithoutAsyncSuffix()).ConfigureAwait(false);
        }

        /// <summary>
        /// Removes the specified user as a named user
        /// </summary>
        public async Task<bool> Security_RemoveNamedUserAsync(string user_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(user_Name).Capitalize(), user_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Security_RemoveNamedUserAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a privilege from the system
        /// </summary>
        public async Task<bool> Security_RemovePrivilegeAsync(int privilege_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(privilege_Id).Capitalize(), privilege_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Security_RemovePrivilegeAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Determines whether or not a user is a named user in the system
        /// </summary>
        public async Task<bool> Security_UserIsNamedAsync(string user_Name, bool userIsNamed_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(user_Name).Capitalize(), user_Name),
                new NamedValue(nameof(userIsNamed_Indicator).Capitalize(), userIsNamed_Indicator.ToYnIndicator())
            );

            return (await ExecuteNativeApiMethodAsync<YnIndicator>(nameof(Security_UserIsNamedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false))
                .ToBool();
        }
    }
}
