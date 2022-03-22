using adduo.elephant.domain.entities.debts_template;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts_template
{
    public class RecurrentTemplateConfiguration : IEntityTypeConfiguration<RecurrentTemplate>
    {
        public void Configure(EntityTypeBuilder<RecurrentTemplate> builder)
        {
            builder.ToTable("debts_templates_recurrents");
        }
    }
}
