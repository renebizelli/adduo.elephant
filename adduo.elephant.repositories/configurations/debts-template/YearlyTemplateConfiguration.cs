using adduo.elephant.domain.dtos.debts.items;
using adduo.elephant.domain.entities.debts_template;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.items
{
    public class YearlyTemplateConfiguration : IEntityTypeConfiguration<YearlyTemplate>
    {
        public void Configure(EntityTypeBuilder<YearlyTemplate> builder)
        {
            builder.ToTable("debts_templates_yearlies");

            builder.Property(p => p.DueMonth).IsRequired();
        }
    }
}
