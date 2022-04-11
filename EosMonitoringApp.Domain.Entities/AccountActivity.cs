using EosMonitoringApp.Domain.Entities.Common;
using System;

namespace EosMonitoringApp.Domain.Entities
{
    public class AccountActivity : IEntity
    {
        public string AccountName { get; set; } = null!;

        public DateTime? LastAutorizationDate { get; set; }

        public int? DaysGone { get; set; }

    }
}
