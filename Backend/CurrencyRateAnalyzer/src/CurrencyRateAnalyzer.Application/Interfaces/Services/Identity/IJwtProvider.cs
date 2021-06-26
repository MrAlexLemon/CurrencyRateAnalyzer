using CurrencyRateAnalyzer.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Application.Interfaces.Services.Identity
{
    public interface IJwtProvider
    {
        AuthDto Create(Guid userId, string role, string audience = null, IDictionary<string, IEnumerable<string>> claims = null);
    }
}
