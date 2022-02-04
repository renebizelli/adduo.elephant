using adduo.elephant.domain.entities;
using Microsoft.EntityFrameworkCore;

namespace adduo.elephant.repositories.seeds
{
    public class CategorySeed
    {
        public Tag[] Categories = new Tag[]
        {
            //new Tag() { Id = 1, Name = "Pais"},
            //new Tag() { Id =2,  Name = "Saúde"},
            //new Tag() { Id =3,  Name = "Celular"},
            //new Tag() { Id =4,  Name = "Cartão de Crédito"},
            //new Tag() { Id =5,  Name = "Unique"},
            //new Tag() { Id =6,  Name = "Reservas"},
            //new Tag() { Id =7,  Name = "Estudos"},
            //new Tag() { Id =8,  Name = "Adduo"},
            //new Tag() { Id =9,  Name = "Avulso"},
            //new Tag() { Id =10, Name =  "Santander"},
        };

        public CategorySeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>().HasData(Categories);
        }
    }
}
