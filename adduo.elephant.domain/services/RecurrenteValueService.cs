using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.services
{
    public class RecurrenteValueService : IRecurrenteValueService
    {
        private readonly IRecurrentValueRepository repository;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public RecurrenteValueService(IRecurrentValueRepository repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<RecurrentValueRequest> AddValueAsync(string id, RecurrentValueRequest request)
        {
            var guid = Guid.Empty;

            if (!Guid.TryParse(id, out guid))
            {
                throw new ArgumentException("id");
            }

            request.Validate();

            if (request.AllFieldsAreValid())
            {
                var entity = mapper.Map<RecurrentValue>(request);

                await repository.AddValueAsync(guid, entity);

                await unitOfWork.CommitAsync();
            }

            return request;
        }
    }
}
