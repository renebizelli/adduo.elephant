using adduo.elephant.domain.entities.debts_template;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts_template
{
    public class InstallmentTemplateConfiguration : IEntityTypeConfiguration<InstallmentTemplate>
    {
        public void Configure(EntityTypeBuilder<InstallmentTemplate> builder)
        {
            builder.ToTable("debts_templates_installments");

            builder.Property(p => p.StartMonth).IsRequired();
            builder.Property(p => p.StartYear).IsRequired();
            builder.Property(p => p.Installments).IsRequired();
            builder.Property(p => p.StartPeriod).IsRequired();
            builder.Property(p => p.FinishPeriod).IsRequired();
        }
    }
}
