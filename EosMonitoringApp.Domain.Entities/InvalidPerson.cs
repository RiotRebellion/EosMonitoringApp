using EosMonitoringApp.Domain.Entities.Common;

namespace EosMonitoringApp.Domain.Entities
{
    public class InvalidPerson : IEntity
    {
        public string? Name { get; set; }
    }
}
