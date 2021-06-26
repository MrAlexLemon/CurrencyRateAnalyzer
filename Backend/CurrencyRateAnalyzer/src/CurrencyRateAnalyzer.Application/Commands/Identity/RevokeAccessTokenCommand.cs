using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CurrencyRateAnalyzer.Application.Commands.Identity
{
    public class RevokeAccessTokenCommand : IRequest
    {
        public Guid UserId { get; }
        public string Token { get; }

        [JsonConstructor]
        public RevokeAccessTokenCommand(Guid userId, string token)
        {
            UserId = userId;
            Token = token;
        }
    }
}
