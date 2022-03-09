using adduo.elephant.domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class CategoryConfiguration : EntityItemConfiguration<Category, int>, IEntityTypeConfiguration<Category>
    {
        public new virtual void Configure(EntityTypeBuilder<Category> builder)
        {
            SetTableName("categories");

            base.Configure(builder);

            //builder.HasMany(m => m.Debts)
            //    .WithOne(o => o.Category)
            //    .HasForeignKey(f => f.CategoryId);
        }
    }
}
