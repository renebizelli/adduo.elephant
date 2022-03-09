using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.services
{
    public class RecurrenteValueService : IRecurrenteValueBundlerService
    {
        private readonly IRecurrentValueBundlerRepository repository;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public RecurrenteValueService(IRecurrentValueBundlerRepository repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<RecurrentValueBundlerRequest> AddValueAsync(string id, RecurrentValueBundlerRequest request)
        {
            var guid = Guid.Empty;

            if (!Guid.TryParse(id, out guid))
            {
                throw new ArgumentException("id");
            }

            request.Validate();

            if (request.AllFieldsAreValid())
            {
                var entity = mapper.Map<RecurrentBundlerValue>(request);

                await repository.AddValueAsync(guid, entity);

                await unitOfWork.CommitAsync();
            }

            return request;
        }


        public async Task<RecurrentValueBundlerRequest> UpdateValueAsync(string recurrentId, string valueId, RecurrentValueBundlerRequest request)
        {
            var recurrentGuid = Guid.Empty;

            if (!Guid.TryParse(recurrentId, out recurrentGuid))
            {
                throw new ArgumentException("recurrentId");
            }

            var id = 0;

            if(!int.TryParse(valueId, out id))
            {
                throw new ArgumentException("valueId");
            }

            request.Validate();

            if (request.AllFieldsAreValid())
            {
                var currentValue = await repository.GetAsync(recurrentGuid, id);

                var entity = mapper.Map(request, currentValue);

                repository.UpdateValue(entity);

                await unitOfWork.CommitAsync();
            }

            return request;
        }
    }
}
