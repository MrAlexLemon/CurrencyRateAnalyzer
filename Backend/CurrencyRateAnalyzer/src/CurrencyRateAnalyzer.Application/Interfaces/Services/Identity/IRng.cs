using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Application.Interfaces.Services.Identity
{
    public interface IRng
    {
        string Generate(int length = 50, bool removeSpecialChars = false);
    }
}
