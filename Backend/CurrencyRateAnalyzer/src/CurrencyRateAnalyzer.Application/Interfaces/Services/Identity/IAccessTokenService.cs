using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRateAnalyzer.Application.Interfaces.Services.Identity
{
    public interface IAccessTokenService
    {
        Task<bool> IsCurrentActiveToken();
        Task DeactivateCurrentAsync(Guid userId);
        Task<bool> IsActiveAsync(string token);
        Task DeactivateAsync(Guid userId, string token);
    }
}
