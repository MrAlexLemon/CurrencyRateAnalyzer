﻿using CurrencyRateAnalyzer.Application.Common;
using CurrencyRateAnalyzer.Domain.Events.Currency;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyRateAnalyzer.Application.Events
{
    public class CurrencyChangedEventHandler : INotificationHandler<DomainEventNotification<CurrencyChangedEvent>>
    {
        private readonly ILogger<CurrencyChangedEventHandler> _logger;

        public CurrencyChangedEventHandler(ILogger<CurrencyChangedEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(DomainEventNotification<CurrencyChangedEvent> notification, CancellationToken cancellationToken)
        {
            var domainEvent = notification.DomainEvent;

            _logger.LogInformation("Domain Event: {DomainEvent}", domainEvent.GetType().Name);

            return Task.CompletedTask;
        }
    }
}
