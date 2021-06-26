using CurrencyRateAnalyzer.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Domain.Exceptions.Identity
{
    public class InvalidUserPasswordException : DomainException
    {
        public override string Code { get; } = "invalid_user_password";
        public Guid Id { get; }
        public string Password { get; }

        public InvalidUserPasswordException(Guid id, string password) : base(
            $"User with id: {id} has invalid password.")
        {
            Id = id;
            Password = password;
        }
    }
}
