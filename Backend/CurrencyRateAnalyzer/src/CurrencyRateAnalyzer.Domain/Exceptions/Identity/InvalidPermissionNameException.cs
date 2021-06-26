using CurrencyRateAnalyzer.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Domain.Exceptions.Identity
{
    public class InvalidPermissionNameException : DomainException
    {
        public override string Code { get; } = "invalid_permission_name";
        public Guid Id { get; }
        public string Name { get; }

        public InvalidPermissionNameException(Guid id, string name) : base(
            $"Permission with id: {id} has invalid name.")
        {
            Id = id;
            Name = name;
        }
    }
}
