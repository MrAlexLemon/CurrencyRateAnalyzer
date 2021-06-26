using CurrencyRateAnalyzer.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Domain.Exceptions.Identity
{
    public class InvalidUserEmailException : DomainException
    {
        public override string Code { get; } = "invalid_user_email";
        public Guid Id { get; }
        public string Email { get; }

        public InvalidUserEmailException(Guid id, string email) : base(
            $"User with id: {id} has invalid email.")
        {
            Id = id;
            Email = email;
        }
    }
}
