using CurrencyRateAnalyzer.Application.Dtos;
using CurrencyRateAnalyzer.Application.Interfaces.Services.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Infrastructure.Services.Identity
{
    public class JwtProvider : IJwtProvider
    {
        private readonly IJwtHandler _jwtHandler;

        public JwtProvider(IJwtHandler jwtHandler)
        {
            _jwtHandler = jwtHandler;
        }

        public AuthDto Create(Guid userId, string role, string audience = null,
            IDictionary<string, IEnumerable<string>> claims = null)
        {
            var jwt = _jwtHandler.CreateToken(userId.ToString("N"), role, audience, claims);

            return new AuthDto
            {
                AccessToken = jwt.AccessToken,
                Role = jwt.Role,
                Expires = jwt.Expires
            };
        }
    }
}
