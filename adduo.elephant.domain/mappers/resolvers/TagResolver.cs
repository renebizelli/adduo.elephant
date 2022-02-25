using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.entities;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using AutoMapper;
using System.Collections.Generic;

namespace adduo.elephant.domain.mappers.resolvers
{
    public class TagResolver : IValueResolver<DebtRequest, Debt, Category>
    {
        private readonly IItemRepository<Category, int> itemRepository;

        public TagResolver()
        {
                
        }

        public TagResolver(IItemRepository<Category, int> itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        public Category Resolve(DebtRequest source, Debt destination, Category destMember, ResolutionContext context)
        {
            var category = new Category(0);

            if(source.CategoryId.HasValue())
            {
                var id = source.CategoryId.GetValue();
                category = itemRepository.Get(id);
            }

            return category;
        }
    }
}
