using CurrencyRateAnalyzer.Domain.Common;
using CurrencyRateAnalyzer.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Domain.Events.Identity
{
    public class PermissionChangedEvent : DomainEvent
    {
        public Permission Permission { get; }

        public PermissionChangedEvent(Permission permission)
        {
            Permission = permission;
        }
    }
}
