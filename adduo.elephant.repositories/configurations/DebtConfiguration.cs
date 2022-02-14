using adduo.elephant.domain.entities.debts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace adduo.elephant.repositories.configurations
{
    public class DebtConfiguration : EntityItemConfiguration<Debt, Guid>, IEntityTypeConfiguration<Debt>
    {
        public new virtual void Configure(EntityTypeBuilder<Debt> builder)
        {
            SetTableName("debts");
            SetMaxLengthName(64);

            base.Configure(builder);

            builder.Property(p => p.CreatedAt)
                .HasColumnType("DateTime")
                .IsRequired();

            builder.Property(p => p.Amount)
                .HasColumnType("Decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.Status)
                .HasColumnType("tinyint")
                .IsRequired();
        }
    }
}
