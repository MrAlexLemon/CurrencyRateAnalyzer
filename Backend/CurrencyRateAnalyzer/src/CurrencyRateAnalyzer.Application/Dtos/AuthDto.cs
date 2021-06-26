using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Application.Dtos
{
    public class AuthDto
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string Role { get; set; }
        public long Expires { get; set; }
    }
}
