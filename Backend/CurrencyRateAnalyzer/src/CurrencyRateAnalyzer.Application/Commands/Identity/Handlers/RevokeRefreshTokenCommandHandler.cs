using CurrencyRateAnalyzer.Application.Interfaces.Services.Identity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyRateAnalyzer.Application.Commands.Identity.Handlers
{
    public class RevokeRefreshTokenCommandHandler : IRequestHandler<RevokeRefreshTokenCommand>
    {
        private readonly IRefreshTokenService _refreshTokenService;

        public RevokeRefreshTokenCommandHandler(IRefreshTokenService refreshTokenService)
        {
            _refreshTokenService = refreshTokenService;
        }

        public async Task<Unit> Handle(RevokeRefreshTokenCommand request, CancellationToken cancellationToken)
        {
            await _refreshTokenService.RevokeAsync(request.Token);
            return Unit.Value;
        }
    }
}
