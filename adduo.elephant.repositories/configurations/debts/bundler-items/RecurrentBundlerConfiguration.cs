using adduo.elephant.domain.entities.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.bundler_items
{
    public class RecurrentBundlerConfiguration : IEntityTypeConfiguration<RecurrentBundler>
    {
        public void Configure(EntityTypeBuilder<RecurrentBundler> builder)
        {
            builder.ToTable("debt_bundler_recurrent_items");
        }
    }
}
