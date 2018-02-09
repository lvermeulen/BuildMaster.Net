using System;

// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class DatabaseConnectionExtended
    {
        public int DatabaseConnection_Id { get; set; }
        public string DatabaseConnection_Name { get; set; }
        public string DatabaseConnection_Description { get; set; }
        public string DatabaseConnection_Configuration { get; set; }
        public int? ExecuteOn_Server_Id { get; set; }
        public string ExecuteOn_Server_Name { get; set; }
        public string ModifiedBy_User_Name { get; set; }
        public DateTime? ModifiedOn_Date { get; set; }
        public int Application_Id { get; set; }
        public string Application_Name { get; set; }
        public int Environment_Id { get; set; }
        public string Environment_Name { get; set; }
    }
}
