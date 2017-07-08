using System.Threading.Tasks;
using BuildMaster.Net.Common;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace BuildMaster.Net
{
    public partial class BuildMasterClient
    {
        //Users_CreateOrUpdateGroup
        //Creates a new user group in the system
        //Group_Name(String)
        //Users_Xml(String)  none

        //Users_CreateOrUpdateUser
        //Creates a new user in the system or updates an existing one.
        //User_Name (String)
        //Display_Name(String)
        //Email_Address(String)
        //Groups_Xml(String)
        //ChangePasswordOnLogin_Indicator(YNIndicator)   none
        
        //Users_DeleteGroup
        //Deletes a user group from the system, but does not delete the users who belong to the group
        //Group_Name(String) none
        
        //Users_DeleteUser
        //Deletes a user from the system
        //User_Name(String)  none
        
        //Users_GetGroups
        //Gets a list of user groups in the system
        //none DataTable(Groups)
        
        //Users_GetUser
        //Gets the details of the specified user, and a list of all the groups the user belongs to
        //User_Name(String)  DataSet(Users, UserGroups)
        
        //Users_GetUsers
        //Gets all the users in the system, along with all group membership information.
        //none DataSet(Users, UserGroups)
        
        //Users_GetUsersInGroup
        //Gets a list of users in the specified group
        //Group_Name(String) DataTable(Users)
        
        //Users_SearchGroups
        //Gets a specific group by name, or if a wildcard search is performed, a group whose name starts with the specified name
        //Group_Name(String)
        //PerformWildcardSearch_Indicator(YNIndicator)   DataTable(Groups)
        
        //Users_SearchUsers
        //Gets the specified user, or searchs for a user whose name starts with any of the specified criteria
        //User_Name(String)
        //Display_Name(String)
        //Email_Address(String)
        //PerformWildcardSearch_Indicator(YNIndicator)   DataTable(Users)
        
        //Users_ValidateLogin
        //Validates the password of a specified user
        //User_Name(String)
        //Password_Text(String)
        //Validated_Indicator(YNIndicator)   Validated_Indicator
    }
}
