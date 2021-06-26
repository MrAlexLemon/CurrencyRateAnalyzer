using CurrencyRateAnalyzer.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Infrastructure.Persistence.Configurations
{
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.Property(t => t.Id).HasConversion<Guid>();
            builder.HasKey(t => t.Id);

            builder.Ignore(e => e.Events);
            builder.Ignore(e => e.Revoked);

            builder.Property(t => t.CreatedAt)
                .IsRequired();

            /*builder.Property(t => t.Revoked)
                .IsRequired();*/

            builder.Property(t => t.Token)
                .IsRequired();
        }
    }
}
