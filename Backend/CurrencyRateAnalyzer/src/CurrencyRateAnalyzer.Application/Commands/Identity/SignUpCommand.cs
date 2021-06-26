using CurrencyRateAnalyzer.Domain.Entities.Identity;
using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Application.Commands.Identity
{
    public class SignUpCommand : IRequest
    {
        public Guid UserId { get; }
        public string Email { get; }
        public string Password { get; }
        public Role Role { get; }

        [JsonConstructor]
        public SignUpCommand(Guid id, string email, string password, Role role)
        {
            UserId = id;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}
