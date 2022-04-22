using EosMonitoringApp.Domain.Entities.Common;
using System;

namespace EosMonitoringApp.Domain.Entities
{
    public class Employee : IEntity
    {
        public string? Name { get; set; }

        public string? Department { get; set; }

        public string? Post { get; set; }

        public int Status { get; set; }
    }
}
