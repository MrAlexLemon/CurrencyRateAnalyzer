using CurrencyRateAnalyzer.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(t => t.Id).HasConversion<Guid>();
            builder.HasKey(t => t.Id);

            builder.Ignore(e => e.Events);

            builder.Property(t => t.Email)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(t => t.Password)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(t => t.Role)
                .IsRequired();
        }
    }
}
