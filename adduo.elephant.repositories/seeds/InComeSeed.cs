using adduo.elephant.domain.entities;
using Microsoft.EntityFrameworkCore;

namespace adduo.elephant.repositories.seeds
{
    public class InComeSeed 
    {
        public InCome[] Categories = new InCome[]
        {
            new InCome( 1, "Salário"),
            new InCome( 2, "VR"),
        };

        public InComeSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InCome>().HasData(Categories);
        }
    }
}
