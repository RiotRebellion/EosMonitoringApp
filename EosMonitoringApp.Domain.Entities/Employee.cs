using EosMonitoringApp.Domain.Entities.Common;
using System;

namespace EosMonitoringApp.Domain.Entities
{
    public class Employee : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Department { get; set; } = null!;

        public string Post { get; set; } = null!;

        public enum Status
        {
            Работает = 0,
            Уволен
        }
    }
}
