﻿// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class RoleTasksExtended
    {
        public int Role_Id { get; set; }
        public int Task_Id { get; set; }
        public string Task_Name { get; set; }
        public bool Application_Scopeable_Indicator { get; set; }
        public bool Environment_Scopeable_Indicator { get; set; }
    }
}
