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
    public class SignUpCommandHandler : IRequestHandler<SignUpCommand>
    {
        private readonly IIdentityService _identityService;

        public SignUpCommandHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public async Task<Unit> Handle(SignUpCommand request, CancellationToken cancellationToken)
        {
            await _identityService.SignUpAsync(request);
            return Unit.Value;
        }
    }
}
