using CurrencyRateAnalyzer.Application.Interfaces.Services.Identity;
using CurrencyRateAnalyzer.Infrastructure.Services.Identity.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRateAnalyzer.Infrastructure.Services.Identity
{
    public class AccessTokenService : IAccessTokenService
    {
        private readonly IDistributedCache _cache;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IOptions<JwtOptions> _jwtOptions;

        public AccessTokenService(IDistributedCache cache,
                IHttpContextAccessor httpContextAccessor,
                IOptions<JwtOptions> jwtOptions)
        {
            _cache = cache;
            _httpContextAccessor = httpContextAccessor;
            _jwtOptions = jwtOptions;
        }

        public async Task<bool> IsCurrentActiveToken()
            => await IsActiveAsync(GetCurrentAsync());

        public async Task DeactivateCurrentAsync(Guid userId)
            => await DeactivateAsync(userId, GetCurrentAsync());

        public async Task<bool> IsActiveAsync(string token)
            => string.IsNullOrWhiteSpace(await _cache.GetStringAsync(GetKey(token)));

        public async Task DeactivateAsync(Guid userId, string token)
        {
            await _cache.SetStringAsync(GetKey(token),
                    "deactivated", new DistributedCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow =
                            TimeSpan.FromMinutes(_jwtOptions.Value.ExpiryMinutes)
                    });
        }

        private string GetCurrentAsync()
        {
            var authorizationHeader = _httpContextAccessor
                .HttpContext.Request.Headers["authorization"];

            return authorizationHeader == StringValues.Empty
                ? string.Empty
                : authorizationHeader.Single().Split(' ').Last();
        }

        private static string GetKey(string token)
            => $"tokens:{token}";
    }
}
