using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.domain.requests.debts_template;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.services
{
    public class DebtTemplateService<TSaveRequest, TEntity> : IDebtTemplateService<TSaveRequest, TEntity>
                where TSaveRequest : DebtTemplateRequest
                where TEntity : DebtTemplate
    {
        private readonly IMapper mapper;
        private readonly IDebtTemplateRepository<TEntity> repository;
        private readonly IUnitOfWork unitOfWork;

        public DebtTemplateService(IMapper mapper, IDebtTemplateRepository<TEntity> repository, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<TSaveRequest> SaveAsync(TSaveRequest request)
        {
            request.Validate();

            if (request.AllFieldsAreValid())
            {
                request.Id = Guid.NewGuid();

                var entity = mapper.Map<TEntity>(request);

                entity.Activate();

                await repository.SaveAsync(entity);

                await unitOfWork.CommitAsync();
            }

            return request;
        }

        public async Task<TSaveRequest> UpdateAsync(string id, TSaveRequest request)
        {
            var guid = Guid.Empty;

            if (!Guid.TryParse(id, out guid))
            {
                throw new ArgumentException("id");
            }

            request.Validate();

            if (request.AllFieldsAreValid())
            {
                request.Id = guid;

                var entity = await repository.GetAsync(guid);

                if (entity == null)
                {
                    request.SetNotFoundHttpStatusCode();
                }
                else
                {
                    mapper.Map<TSaveRequest, TEntity>(request, entity);
                    await unitOfWork.CommitAsync();
                }
            }

            return request;
        }
    }
}
