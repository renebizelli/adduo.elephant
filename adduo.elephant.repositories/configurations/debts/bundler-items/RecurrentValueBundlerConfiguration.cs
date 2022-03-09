﻿using adduo.elephant.domain.entities.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.bundler_items
{
    public class RecurrentValueBundlerConfiguration : IEntityTypeConfiguration<RecurrentBundlerValue>
    {
        public void Configure(EntityTypeBuilder<RecurrentBundlerValue> builder)
        {
            builder.ToTable("debt_bundler_recurrent_values");

            builder.Property(p => p.Description)
                    .HasColumnType("varchar(64)")
                    .HasMaxLength(64);

            builder.Property(p => p.CreatedAt)
                    .HasColumnType("DateTime")
                    .IsRequired();

            builder.Property(p => p.Amount)
                    .HasColumnType("Decimal(18,2)")
                    .IsRequired();

            builder.HasOne(p => p.Recurrent)
                    .WithMany(m => m.Values)
                    .HasForeignKey(f => f.RecurrentId);
        }
    }
}