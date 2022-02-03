using adduo.elephant.domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class SpreadSheetConfiguration : IEntityTypeConfiguration<SpreadSheet>
    {
        public void Configure(EntityTypeBuilder<SpreadSheet> builder)
        {
            builder.ToTable("spreadsheets");
            builder.HasKey(p => p.Id);

            builder.HasIndex(i => new { i.Year, i.Month })
                .IsUnique();

            builder.HasMany(m => m.Items)
                .WithOne(o => o.SpreadSheet)
                .HasForeignKey(f => f.SpreadSheetId);
        }
    }
}
