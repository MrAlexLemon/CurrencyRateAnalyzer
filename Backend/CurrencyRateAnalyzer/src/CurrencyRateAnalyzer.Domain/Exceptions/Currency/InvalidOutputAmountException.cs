using CurrencyRateAnalyzer.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Domain.Exceptions.Currency
{
    public class InvalidOutputAmountException : DomainException
    {
        public override string Code { get; } = "invalid_exchangeMoneyInfo_outputAmount";
        public Guid Id { get; }
        public decimal OutputAmount { get; }

        public InvalidOutputAmountException(Guid id, decimal outputAmount) : base(
            $"ExchangeMoneyInfo with id: {id} has invalid outputAmount.")
        {
            Id = id;
            OutputAmount = outputAmount;
        }
    }
}
