using CurrencyRateAnalyzer.Application.Dtos;
using CurrencyRateAnalyzer.Application.Interfaces.Services.Identity;
using CurrencyRateAnalyzer.Domain.Entities.Identity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyRateAnalyzer.Application.Commands.Identity.Handlers
{
    public class RefreshAccessTokenCommandHandler : IRequestHandler<RefreshAccessTokenCommand, AuthDto>
    {
        private readonly IRefreshTokenService _refreshTokenService;
        
        public RefreshAccessTokenCommandHandler(IRefreshTokenService refreshTokenService)
        {
            _refreshTokenService = refreshTokenService;
        }

        public async Task<AuthDto> Handle(RefreshAccessTokenCommand request, CancellationToken cancellationToken)
        {
            return await _refreshTokenService.UseAsync(request.Token);
        }
    }
}
