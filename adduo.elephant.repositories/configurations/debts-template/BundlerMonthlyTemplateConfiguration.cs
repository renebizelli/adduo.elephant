using adduo.elephant.domain.entities.debts_template;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts_template
{
    public class BundlerMonthlyTemplateConfiguration : IEntityTypeConfiguration<BundlerMonthlyTemplate>
    {
        public void Configure(EntityTypeBuilder<BundlerMonthlyTemplate> builder)
        {
            builder.ToTable("debts_templates_bundlers_monthlies");

            builder.HasMany(m => m.Debts)
                .WithOne(o => o.BundlerMonthlyTemplate)
                .HasForeignKey(f => f.BundlerTemplateId);
        }
    }
}
