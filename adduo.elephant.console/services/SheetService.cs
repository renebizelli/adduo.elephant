using adduo.elephant.console.repositories;

namespace adduo.elephant.console.servicesS
{
    public class SheetService
    {
        private readonly SheetRepository repository;

        public SheetService()
        {
            repository = new SheetRepository();
        }

        public Sheet Get(int month, int year)
        {
            var itWasCreated = repository.ItWasCreated(month, year);

            var sheet = repository.Get(month, year);

            return sheet;
        }
    }
}
