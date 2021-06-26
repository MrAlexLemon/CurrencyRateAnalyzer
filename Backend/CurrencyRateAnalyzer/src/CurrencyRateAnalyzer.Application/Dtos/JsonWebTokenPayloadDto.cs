using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Application.Dtos
{
    public class JsonWebTokenPayloadDto
    {
        public string Subject { get; set; }
        public string Role { get; set; }
        public long Expires { get; set; }
        public IDictionary<string, IEnumerable<string>> Claims { get; set; }
    }
}
