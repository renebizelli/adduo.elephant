using adduo.elephant.domain.entities.debts_template;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.items
{
    public class PontualTemplateConfiguration : IEntityTypeConfiguration<PontualTemplate>
    {
        public void Configure(EntityTypeBuilder<PontualTemplate> builder)
        {
            builder.ToTable("debts_templates_pontuals");

            builder.Property(p => p.DueMonth)
                .IsRequired();

            builder.Property(p => p.DueYear)
                .IsRequired();
        }
    }
}
