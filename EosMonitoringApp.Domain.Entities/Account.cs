using EosMonitoringApp.Domain.Entities.Common;

namespace EosMonitoringApp.Domain.Entities
{
    public class Account : IEntity
    {
        public string Department { get; set; } = null!;

        public string Cabinet { get; set; } = null!;

        public string? Username { get; set; }

        public string? FolderAccess { get; set; }
    }
}
