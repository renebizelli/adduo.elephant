using adduo.elephant.domain.entities.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.bundler_items
{
    public class RecurrentValueConfiguration : IEntityTypeConfiguration<RecurrentValue>
    {
        public void Configure(EntityTypeBuilder<RecurrentValue> builder)
        {
            builder.ToTable("debt_bundler_recurrent_values");

            builder.Property(p => p.Description)
                    .HasColumnType("varchar(64)")
                    .HasMaxLength(64);

            builder.Property(p => p.CreatedAt)
                    .HasColumnType("DateTime")
                    .IsRequired();

            builder.Property(p => p.Value)
                    .HasColumnType("Decimal(18,2)")
                    .IsRequired();

            builder.HasOne(p => p.Recurrent)
                    .WithMany(m => m.Values)
                    .HasForeignKey(f => f.RecurrentId);
        }
    }
}
