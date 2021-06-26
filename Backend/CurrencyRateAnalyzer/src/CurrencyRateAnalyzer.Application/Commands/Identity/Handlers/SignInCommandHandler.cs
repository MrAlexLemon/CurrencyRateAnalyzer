using CurrencyRateAnalyzer.Application.Dtos;
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
    public class SignInCommandHandler : IRequestHandler<SignInCommand, AuthDto>
    {
        private readonly IIdentityService _identityService;
        
        public SignInCommandHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public async Task<AuthDto> Handle(SignInCommand request, CancellationToken cancellationToken)
        {
            return await _identityService.SignInAsync(request);
        }
    }
}
