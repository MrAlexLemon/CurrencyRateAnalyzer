using CurrencyRateAnalyzer.Domain.Entities.Currency;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Infrastructure.Persistence.Configurations
{
    public class ExchangeMoneyInfoConfiguration : IEntityTypeConfiguration<ExchangeMoneyInfo>
    {
        public void Configure(EntityTypeBuilder<ExchangeMoneyInfo> builder)
        {
            builder.Property(t => t.Id).HasConversion<Guid>();
            builder.HasKey(t => t.Id);

            builder.Ignore(e => e.Events);

            builder.Property(t => t.InputAmount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(t => t.InputСurrency)
                .IsRequired();

            builder.Property(t => t.OutputAmount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(t => t.OutputСurrency)
                .IsRequired();
        }
    }
}
