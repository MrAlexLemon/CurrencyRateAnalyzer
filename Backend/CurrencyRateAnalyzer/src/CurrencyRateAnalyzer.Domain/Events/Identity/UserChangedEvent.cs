using CurrencyRateAnalyzer.Domain.Common;
using CurrencyRateAnalyzer.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Domain.Events.Identity
{
    public class UserChangedEvent : DomainEvent
    {
        public User User { get; }

        public UserChangedEvent(User user)
        {
            User = user;
        }
    }
}
