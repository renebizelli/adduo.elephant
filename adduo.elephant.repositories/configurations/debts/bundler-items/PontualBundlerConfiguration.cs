using adduo.elephant.domain.entities.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.bundler_items
{
    public class PontualBundlerConfiguration : IEntityTypeConfiguration<PontualBundler>
    {
        public void Configure(EntityTypeBuilder<PontualBundler> builder)
        {
            builder.ToTable("debt_bundler_pontual_items");

            builder.Property(p => p.Month)
                .IsRequired();

            builder.Property(p => p.Year)
                .IsRequired();
        }
    }
}
