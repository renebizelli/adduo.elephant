using adduo.elephant.domain.entities;
using adduo.elephant.repositories;
using System.Collections.Generic;

namespace adduo.elephant.test.services.scenarios
{
    public class DatabaseScenario : BaseScenario
    {
        public ElephantContext Create()
        {
            var categories = new List<Category>
            {
                new Category(1, "AAAAA"),
                new Category(2, "BBBBB"),
                new Category(3, "BBBBB")
            };
            SetMockDbSet<Category, int>(categories);

            return context.Object;
        }
    }
}
