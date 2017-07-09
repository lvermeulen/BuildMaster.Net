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
        /// Creates a new database connection or updates an existing one
        /// </summary>
        /// <returns>DatabaseConnection_Id</returns>
        public async Task<int> DatabaseConnections_CreateOrUpdateConnectionAsync(
            string databaseConnection_Name,
            string databaseConnection_Description,
            string databaseConnection_Configuration,
            int executeOn_Server_Id,
            int application_Id,
            int environment_Id,
            int databaseConnection_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(databaseConnection_Name).Capitalize(), databaseConnection_Name),
                new NamedValue(nameof(databaseConnection_Description).Capitalize(), databaseConnection_Description),
                new NamedValue(nameof(databaseConnection_Configuration).Capitalize(), databaseConnection_Configuration),
                new NamedValue(nameof(executeOn_Server_Id).Capitalize(), executeOn_Server_Id),
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(environment_Id).Capitalize(), environment_Id),
                new NamedValue(nameof(databaseConnection_Id).Capitalize(), databaseConnection_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(DatabaseConnections_CreateOrUpdateConnectionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a database connection
        /// </summary>
        public async Task<bool> DatabaseConnections_DeleteConnectionAsync(int databaseConnection_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(databaseConnection_Id).Capitalize(), databaseConnection_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(DatabaseConnections_DeleteConnectionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a database connection
        /// </summary>
        public async Task<DatabaseConnectionExtended> DatabaseConnections_GetConnectionAsync(int databaseConnection_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(databaseConnection_Id).Capitalize(), databaseConnection_Id)
            );

            return await ExecuteNativeApiMethodAsync<DatabaseConnectionExtended>(nameof(DatabaseConnections_GetConnectionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets database connections, optionally filtered by application and environment
        /// </summary>
        public async Task<IEnumerable<DatabaseConnectionExtended>> DatabaseConnections_GetConnectionsAsync(
            int? application_Id = null,
            int? environment_Id = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(application_Id).Capitalize(), application_Id),
                new NamedValue(nameof(environment_Id).Capitalize(), environment_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<DatabaseConnectionExtended>>(nameof(DatabaseConnections_GetConnectionsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
