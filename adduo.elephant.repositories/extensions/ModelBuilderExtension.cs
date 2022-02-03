using adduo.elephant.repositories.seeds;
using Microsoft.EntityFrameworkCore;

namespace adduo.elephant.repositories.extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seeds(this ModelBuilder modelBuilder)
        {
            new CategorySeed(modelBuilder);
            new InComeSeed(modelBuilder);
        }
    }
}
