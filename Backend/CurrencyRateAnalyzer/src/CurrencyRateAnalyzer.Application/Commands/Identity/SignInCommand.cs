using CurrencyRateAnalyzer.Application.Dtos;
using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Application.Commands.Identity
{
    public class SignInCommand : IRequest<AuthDto>
    {
        public string Email { get; }
        public string Password { get; }

        [JsonConstructor]
        public SignInCommand(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
