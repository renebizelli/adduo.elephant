using adduo.elephant.domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class EntityItemConfiguration<T, T1> where T : EntityItem<T1> 
    {
        private int MaxLengthName { get; set; }
        private string TableName { get; set; }

        public EntityItemConfiguration()
        {
            MaxLengthName = 32;
        }

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.ToTable(TableName);

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(MaxLengthName)
                .IsRequired();
        }

        protected void SetMaxLengthName(int value)
        {
            MaxLengthName = value;
        }

        protected void SetTableName(string value)
        {
            TableName = value;
        }
    }
}
