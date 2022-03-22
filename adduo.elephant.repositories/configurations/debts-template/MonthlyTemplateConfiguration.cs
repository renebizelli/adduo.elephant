using adduo.elephant.domain.entities.debts_template;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts_template
{
    public class MonthlyTemplateConfiguration : IEntityTypeConfiguration<MonthlyTemplate>
    {
        public void Configure(EntityTypeBuilder<MonthlyTemplate> builder)
        {
            builder.ToTable("debts_templates_monthlies");
        }
    }
}
