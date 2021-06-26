using CurrencyRateAnalyzer.Domain.Common;
using CurrencyRateAnalyzer.Domain.Entities.Identity;
using CurrencyRateAnalyzer.Domain.Events.Currency;
using CurrencyRateAnalyzer.Domain.Exceptions.Currency;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Domain.Entities.Currency
{
    public class ExchangeMoneyInfo : AggregateRoot
    {
        public Сurrency InputСurrency { get; private set; }
        public Сurrency OutputСurrency { get; private set; }
        public decimal InputAmount { get; private set; }
        public decimal OutputAmount { get; private set; }


        public User User { get; private set; }
        public Guid UserId { get; private set; }


        protected ExchangeMoneyInfo()
        {
        }

        public ExchangeMoneyInfo(Guid id, Сurrency inputСurrency, Сurrency outputСurrency, decimal inputAmount, decimal outputAmount, Guid userId)
        {
            Id = id;
            InputСurrency = inputСurrency;
            OutputСurrency = outputСurrency;
            
            if(inputСurrency <= 0)
                throw new InvalidInputAmountException(Id, inputAmount);

            if(outputAmount <=0 )
                throw new InvalidOutputAmountException(Id, outputAmount);

            InputAmount = inputAmount;
            OutputAmount = outputAmount;
            UserId = userId;

            AddEvent(new CurrencyChangedEvent(this));
        }
    }
}
