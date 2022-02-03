using adduo.elephant.domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class InComeConfiguration : EntityItemConfiguration<InCome, int>, IEntityTypeConfiguration<InCome>
    {
        public new virtual void Configure(EntityTypeBuilder<InCome> builder)
        {
            SetTableName("incomes");
            base.Configure(builder);
        }
    }
}
