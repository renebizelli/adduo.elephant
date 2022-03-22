using adduo.elephant.domain.entities.debts_template;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace adduo.elephant.repositories.configurations.debts_template
{
    public class DebtTemplateConfiguration : EntityItemConfiguration<DebtTemplate, Guid>, IEntityTypeConfiguration<DebtTemplate>
    {
        public new virtual void Configure(EntityTypeBuilder<DebtTemplate> builder)
        {
            SetTableName("debts_templates");
            SetMaxLengthName(64);

            base.Configure(builder);

            builder.Property(p => p.DueDay)
                .IsRequired();

            builder.Property(p => p.Status)
                .HasColumnType("tinyint")
                .IsRequired();

            builder.Property(p => p.CreatedAt)
                .HasColumnType("DateTime")
                .IsRequired();

            builder.HasOne(m => m.Category)
                .WithMany()
                .HasForeignKey(f => f.CategoryId);

            builder.HasOne(m => m.BundlerMonthlyTemplate)
                .WithMany(m => m.Debts)
                .HasForeignKey(f => f.BundlerTemplateId);

            //builder.HasDiscriminator<int>("Type")
            //.HasValue<domain.entities.debts_template.Item>(1)
            //.HasValue<domain.entities.debts.bundler_items.Item>(2);


        }
    }
}
