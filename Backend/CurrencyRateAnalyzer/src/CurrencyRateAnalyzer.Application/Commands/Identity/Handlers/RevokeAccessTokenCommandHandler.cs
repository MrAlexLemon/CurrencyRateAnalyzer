using CurrencyRateAnalyzer.Application.Interfaces.Services.Identity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyRateAnalyzer.Application.Commands.Identity.Handlers
{
    public class RevokeAccessTokenCommandHandler : IRequestHandler<RevokeAccessTokenCommand>
    {
        private readonly IAccessTokenService _accessTokenService;
        
        public RevokeAccessTokenCommandHandler(IAccessTokenService accessTokenService)
        {
            _accessTokenService = accessTokenService;
        }

        public async Task<Unit> Handle(RevokeAccessTokenCommand request, CancellationToken cancellationToken)
        {
            await _accessTokenService.DeactivateCurrentAsync(request.UserId);

            return Unit.Value;
        }
    }
}
