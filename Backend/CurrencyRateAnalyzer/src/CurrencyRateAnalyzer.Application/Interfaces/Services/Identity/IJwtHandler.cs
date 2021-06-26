using CurrencyRateAnalyzer.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Application.Interfaces.Services.Identity
{
    public interface IJwtHandler
    {
        JsonWebTokenDto CreateToken(string userId, string role = null, string audience = null, IDictionary<string, IEnumerable<string>> claims = null);
        JsonWebTokenPayloadDto GetTokenPayload(string accessToken);
    }
}
