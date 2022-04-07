using EosMonitoringApp.Domain.Entities.Common;

namespace EosMonitoringApp.Domain.Entities
{
    public class Account : IEntity
    {
        public string Department { get; set; } = null!;

        public string CabinetName { get; set; } = null!;

        public string? AccountName { get; set; }

        public string? FolderAccess { get; set; }

        public string? Employee { get; set; }

        public enum Status
        {
            Действительный = 0,
            Недействительный
        }
    }
}
