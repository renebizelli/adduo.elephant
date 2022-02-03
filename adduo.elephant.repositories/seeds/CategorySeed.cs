using adduo.elephant.domain.entities;
using Microsoft.EntityFrameworkCore;

namespace adduo.elephant.repositories.seeds
{
    public class CategorySeed 
    {
        public Category[] Categories = new Category[]
        {
            new Category( 1, "Pais"),
            new Category( 2, "Saúde"),
            new Category( 3, "Celular"),
            new Category( 4, "Cartão de Crédito"),
            new Category( 5, "Unique"),
            new Category( 6, "Reservas"),
            new Category( 7, "Estudos"),
            new Category( 8, "Adduo"),
            new Category( 9, "Avulso"),
            new Category( 10, "Santander"),
        };

        public CategorySeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(Categories);
        }
    }
}
