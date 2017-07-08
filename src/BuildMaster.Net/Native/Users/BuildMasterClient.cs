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
        /// Creates a new user group in the system
        /// </summary>
        public async Task<bool> Users_CreateOrUpdateGroupAsync(
            string group_Name,
            string users_Xml)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(group_Name).Capitalize(), group_Name),
                new NamedValue(nameof(users_Xml).Capitalize(), users_Xml)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Users_CreateOrUpdateGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a new user in the system or updates an existing one
        /// </summary>
        public async Task<bool> Users_CreateOrUpdateUserAsync(
            string user_Name,
            string display_Name,
            string email_Address,
            string groups_Xml,
            bool changePasswordOnLogin_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(user_Name).Capitalize(), user_Name),
                new NamedValue(nameof(display_Name).Capitalize(), display_Name),
                new NamedValue(nameof(email_Address).Capitalize(), email_Address),
                new NamedValue(nameof(groups_Xml).Capitalize(), groups_Xml),
                new NamedValue(nameof(changePasswordOnLogin_Indicator).Capitalize(), changePasswordOnLogin_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync(nameof(Users_CreateOrUpdateUserAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a user group from the system, but does not delete the users who belong to the group
        /// </summary>
        public async Task<bool> Users_DeleteGroupAsync(string group_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(group_Name).Capitalize(), group_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Users_DeleteGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a user from the system
        /// </summary>
        public async Task<bool> Users_DeleteUserAsync(string user_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(user_Name).Capitalize(), user_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Users_DeleteUserAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of user groups in the system
        /// </summary>
        public async Task<IEnumerable<Group>> Users_GetGroupsAsync() => 
            await ExecuteNativeApiMethodAsync<IEnumerable<Group>>(nameof(Users_GetGroupsAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

        /// <summary>
        /// Gets the details of the specified user, and a list of all the groups the user belongs to
        /// </summary>
        public async Task<UsersUserGroups> Users_GetUserAsync(string user_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(user_Name).Capitalize(), user_Name)
            );

            return await ExecuteNativeApiMethodAsync<UsersUserGroups>(nameof(Users_GetUserAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all the users in the system, along with all group membership information
        /// </summary>
        public async Task<UsersUserGroups> Users_GetUsersAsync() => 
            await ExecuteNativeApiMethodAsync<UsersUserGroups>(nameof(Users_GetUsersAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

        /// <summary>
        /// Gets a list of users in the specified group
        /// </summary>
        public async Task<IEnumerable<User>> Users_GetUsersInGroupAsync(string group_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(group_Name).Capitalize(), group_Name)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<User>>(nameof(Users_GetUsersInGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a specific group by name, or if a wildcard search is performed, a group whose name starts with the specified name
        /// </summary>
        public async Task<IEnumerable<Group>> Users_SearchGroupsAsync(
            string group_Name,
            bool performWildcardSearch_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(group_Name).Capitalize(), group_Name),
                new NamedValue(nameof(performWildcardSearch_Indicator).Capitalize(), performWildcardSearch_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<Group>>(nameof(Users_SearchGroupsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified user, or searchs for a user whose name starts with any of the specified criteria
        /// </summary>
        public async Task<IEnumerable<User>> Users_SearchUsersAsync(
            string user_Name,
            string display_Name,
            string email_Address,
            bool performWildcardSearch_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(user_Name).Capitalize(), user_Name),
                new NamedValue(nameof(display_Name).Capitalize(), display_Name),
                new NamedValue(nameof(email_Address).Capitalize(), email_Address),
                new NamedValue(nameof(performWildcardSearch_Indicator).Capitalize(), performWildcardSearch_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<User>>(nameof(Users_SearchUsersAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Validates the password of a specified user
        /// </summary>
        /// <returns>Validated_Indicator</returns>
        public async Task<bool> Users_ValidateLoginAsync(
            string user_Name,
            string password_Text,
            bool validated_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(user_Name).Capitalize(), user_Name),
                new NamedValue(nameof(password_Text).Capitalize(), password_Text),
                new NamedValue(nameof(validated_Indicator).Capitalize(), validated_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<bool>(nameof(Users_ValidateLoginAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
