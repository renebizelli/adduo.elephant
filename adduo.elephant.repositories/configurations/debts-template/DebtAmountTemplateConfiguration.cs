using adduo.elephant.domain.entities.debts_template;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace adduo.elephant.repositories.configurations.debts_template
{
    public class DebtAmountTemplateConfiguration : EntityItemConfiguration<DebtAmountTemplate, Guid>, IEntityTypeConfiguration<DebtAmountTemplate>
    {
        public new virtual void Configure(EntityTypeBuilder<DebtAmountTemplate> builder)
        {
            builder.ToTable("debts_templates_amounts");

            builder.Property(p => p.Amount)
                .HasColumnType("Decimal(18,2)")
                .IsRequired();
        }
    }
}
