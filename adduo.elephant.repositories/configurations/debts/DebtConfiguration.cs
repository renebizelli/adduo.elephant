using adduo.elephant.domain.entities.debts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace adduo.elephant.repositories.configurations.debts
{
    public class DebtConfiguration : EntityItemConfiguration<Debt, Guid>, IEntityTypeConfiguration<Debt>
    {
        public new virtual void Configure(EntityTypeBuilder<Debt> builder)
        {
            SetTableName("debts");
            SetMaxLengthName(64);

            base.Configure(builder);

            builder.Property(p => p.CreatedAt)
                .HasColumnType("DateTime")
                .IsRequired();

            builder.Property(p => p.Status)
                .HasColumnType("tinyint")
                .IsRequired();

            builder.HasMany(m => m.SpreadSheetItems)
                .WithOne(o => o.Debt)
                .HasForeignKey(f => f.DebtId);

            builder.HasOne(m => m.Category)
                .WithMany()
                .HasForeignKey(f => f.CategoryId);

            //builder.HasDiscriminator<int>("Type")
            //.HasValue<domain.entities.debts.items.Item>(1)
            //.HasValue<domain.entities.debts.bundler_items.Item>(2);


        }
    }
}
