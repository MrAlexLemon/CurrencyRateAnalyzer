using CurrencyRateAnalyzer.Domain.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Application.Common
{
    public class DomainEventNotification<TDomainEvent> : INotification where TDomainEvent : DomainEvent
    {
        public DomainEventNotification(TDomainEvent domainEvent)
        {
            DomainEvent = domainEvent;
        }

        public TDomainEvent DomainEvent { get; }
    }
}
