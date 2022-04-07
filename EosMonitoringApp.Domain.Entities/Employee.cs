using EosMonitoringApp.Domain.Entities.Common;

namespace EosMonitoringApp.Domain.Entities
{
    public class Employee : IEntity
    {
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
