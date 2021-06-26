﻿using CurrencyRateAnalyzer.Application.Interfaces.Services.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CurrencyRateAnalyzer.Infrastructure.Services.Identity
{
    internal sealed class Rng : IRng
    {
        private static readonly string[] SpecialChars = new[] { "/", "\\", "=", "+", "?", ":", "&" };
        public string Generate(int length = 50, bool removeSpecialChars = false)
        {
            using var rng = new RNGCryptoServiceProvider();
            var bytes = new byte[length];
            rng.GetBytes(bytes);
            var result = Convert.ToBase64String(bytes);

            return removeSpecialChars ? SpecialChars.Aggregate(result, (current, chars) => current.Replace(chars, string.Empty)) : result;
        }
    }
}
