using adduo.elephant.domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class TagConfiguration : EntityItemConfiguration<Tag, int>, IEntityTypeConfiguration<Tag>
    {
        public new virtual void Configure(EntityTypeBuilder<Tag> builder)
        {
            SetTableName("tags");

            base.Configure(builder);

            builder.HasMany(m => m.Debts)
                .WithMany(o => o.Tags)
                .UsingEntity(u => u.ToTable("debts_tags"));
        }
    }
}
