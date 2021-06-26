using CurrencyRateAnalyzer.Domain.Common;
using CurrencyRateAnalyzer.Domain.Entities.Currency;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Domain.Events.Currency
{
    public class CurrencyChangedEvent : DomainEvent
    {
        public ExchangeMoneyInfo ExchangeMoneyInfo { get; }

        public CurrencyChangedEvent(ExchangeMoneyInfo exchangeMoneyInfo)
        {
            ExchangeMoneyInfo = exchangeMoneyInfo;
        }
    }
}
