using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.entities;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using AutoMapper;
using System.Collections.Generic;

namespace adduo.elephant.domain.mappers.resolvers
{
    public class TagResolver : IValueResolver<DebtRequest, Debt, List<Tag>>
    {
        private readonly IItemRepository<Tag, int> itemRepository;

        public TagResolver()
        {
                
        }

        public TagResolver(IItemRepository<Tag, int> itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        public List<Tag> Resolve(DebtRequest source, Debt destination, List<Tag> destMember, ResolutionContext context)
        {
            var tags = new List<Tag>();

            foreach (var id in source.Tags.Value)
            {
                var tag = itemRepository.Get(id);

                if (tag is Tag)
                {
                    tags.Add(tag);
                }

            }

            return tags;
        }
    }
}
