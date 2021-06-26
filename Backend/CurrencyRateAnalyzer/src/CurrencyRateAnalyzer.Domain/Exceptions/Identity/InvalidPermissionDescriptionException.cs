using CurrencyRateAnalyzer.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Domain.Exceptions.Identity
{
    public class InvalidPermissionDescriptionException : DomainException
    {
        public override string Code { get; } = "invalid_permission_description";
        public Guid Id { get; }
        public string Description { get; }

        public InvalidPermissionDescriptionException(Guid id, string description) : base(
            $"Permission with id: {id} has invalid description.")
        {
            Id = id;
            Description = description;
        }
    }
}
