using CurrencyRateAnalyzer.Application.Common;
using CurrencyRateAnalyzer.Domain.Events.Identity;
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
    public class PermissionChangedEventHandler : INotificationHandler<DomainEventNotification<PermissionChangedEvent>>
    {
        private readonly ILogger<PermissionChangedEventHandler> _logger;

        public PermissionChangedEventHandler(ILogger<PermissionChangedEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(DomainEventNotification<PermissionChangedEvent> notification, CancellationToken cancellationToken)
        {
            var domainEvent = notification.DomainEvent;

            _logger.LogInformation("Domain Event: {DomainEvent}", domainEvent.GetType().Name);

            return Task.CompletedTask;
        }
    }
}
