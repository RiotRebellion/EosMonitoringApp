using EosMonitoringApp.Domain.Entities.Common;

namespace EosMonitoringApp.Domain.Entities
{
    public class Cabinet : IEntity
    {
        public string EmployeeName { get; set; } = null!;

        public string Department { get; set; } = null!;

        public string? ParentDepartment { get; set; }

        public string? CabinetName { get; set; }

        public string? CabinetDepartment { get; set; }
    }
}
