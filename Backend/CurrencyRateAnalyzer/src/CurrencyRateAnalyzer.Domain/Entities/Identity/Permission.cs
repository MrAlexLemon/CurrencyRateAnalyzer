using CurrencyRateAnalyzer.Domain.Common;
using CurrencyRateAnalyzer.Domain.Events.Identity;
using CurrencyRateAnalyzer.Domain.Exceptions.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Domain.Entities.Identity
{
    public class Permission : AggregateRoot
    {
        public string Name { get; private set; }
        public string Description { get; private set; }


        public List<User> Users { get; private set; }


        protected Permission()
        {
        }

        public Permission(Guid id, string name, string description, List<User> users = null)
        {
            Id = id;

            SetName(name);
            SetDescription(description);

            Users = users ?? new List<User>();

            AddEvent(new PermissionChangedEvent(this));
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new InvalidPermissionNameException(Id, name);
            }
            Name = name;

            AddEvent(new PermissionChangedEvent(this));
        }

        public void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new InvalidPermissionDescriptionException(Id, description);
            }
            Description = description;

            AddEvent(new PermissionChangedEvent(this));
        }
    }
}
