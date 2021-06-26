using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRateAnalyzer.Application.Exceptions.Identity
{
    public class InvalidRefreshTokenException : AppException
    {
        public override string Code { get; } = "invalid_refresh_token";

        public InvalidRefreshTokenException() : base("Invalid refresh token.")
        {
        }
    }
}
