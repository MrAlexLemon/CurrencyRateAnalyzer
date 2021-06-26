using CurrencyRateAnalyzer.Application.Commands.Identity;
using CurrencyRateAnalyzer.Infrastructure.Attributes;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyRateAnalyzer.Api.Controllers
{
    [Route("")]
    [ApiController]
    [JwtAuth]
    public class TokensController : BaseController
    {
        private readonly IMediator _mediator;

        public TokensController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("index2")]
        public IActionResult Index() => Content($"Hello.");

        [HttpPost("access-tokens/{refreshToken}/refresh")]
        [AllowAnonymous]
        public async Task<IActionResult> RefreshAccessToken(string refreshToken, RefreshAccessTokenCommand command)
        {
            var result = await _mediator.Send(command);
            return result == null ? NoContent() : Ok(result);
        }

        [HttpPost("access-tokens/revoke")]
        public async Task<IActionResult> RevokeAccessToken(RevokeAccessTokenCommand command)
        {
            await _mediator.Send(command);
            return Accepted();
        }

        [HttpPost("refresh-tokens/{refreshToken}/revoke")]
        public async Task<IActionResult> RevokeRefreshToken(string refreshToken, RevokeRefreshTokenCommand command)
        {
            await _mediator.Send(command);
            return Accepted();
        }
    }
}
