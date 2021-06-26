using CurrencyRateAnalyzer.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CurrencyRateAnalyzer.Application.Commands.Identity
{
    public class RefreshAccessTokenCommand : IRequest<AuthDto>
    {
        public string Token { get; }

        [JsonConstructor]
        public RefreshAccessTokenCommand(string token)
        {
            Token = token;
        }
    }
}
