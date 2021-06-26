using CurrencyRateAnalyzer.Domain.Common;
using CurrencyRateAnalyzer.Domain.Entities.Currency;
using CurrencyRateAnalyzer.Domain.Events.Identity;
using CurrencyRateAnalyzer.Domain.Exceptions.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrencyRateAnalyzer.Domain.Entities.Identity
{
    public class User : AggregateRoot
    {
        public string Email { get; private set; }
        public Role Role { get; private set; }
        public string Password { get; private set; }
        
        public List<Permission> Permissions { get; private set; }
        public List<ExchangeMoneyInfo> ExchangeMoneyInfos { get; private set; }

        protected User()
        {
        }

        public User(Guid id, string email, string password, Role role = Role.User, 
            List<ExchangeMoneyInfo> exchangeMoneyInfos = null,
            List<Permission> permissions = null)
        {

            Id = id;

            SetEmail(email.ToLowerInvariant());
            SetPassword(password);

            Role = role;
            Permissions = permissions ?? new List<Permission>();
            ExchangeMoneyInfos = exchangeMoneyInfos ?? new List<ExchangeMoneyInfo>();

            AddEvent(new UserChangedEvent(this));
        }

        public void SetPassword(string passwordHash)
        {
            if (string.IsNullOrWhiteSpace(passwordHash))
            {
                throw new InvalidUserPasswordException(Id, passwordHash);
            }
            Password = passwordHash;

            AddEvent(new UserChangedEvent(this));
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new InvalidUserEmailException(Id, email);
            }
            Email = email;

            AddEvent(new UserChangedEvent(this));
        }
    }
}
