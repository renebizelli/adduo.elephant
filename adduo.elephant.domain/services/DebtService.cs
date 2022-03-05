using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.services
{
    public class DebtService<TSaveRequest, TEntity> : DebtService<TSaveRequest, TSaveRequest, TEntity>, IDebtService<TSaveRequest, TEntity>
                where TSaveRequest : DebtRequest
                where TEntity : Debt
    {
        public DebtService(IMapper mapper, IDebtRepository<TEntity> repository, IUnitOfWork unitOfWork) : base(mapper, repository, unitOfWork)
        {
        }
    }

    public class DebtService<TSaveRequest, TUpdateRequest, TEntity> : IDebtService<TSaveRequest, TUpdateRequest, TEntity>
                where TSaveRequest : DebtRequest
                where TUpdateRequest : DebtRequest
                where TEntity : Debt
    {
        private readonly IMapper mapper;
        private readonly IDebtRepository<TEntity> repository;
        private readonly IUnitOfWork unitOfWork;

        public DebtService(IMapper mapper, IDebtRepository<TEntity> repository, IUnitOfWork unitOfWork)
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

        public async Task<TUpdateRequest> UpdateAsync(string id, TUpdateRequest request)
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
                    mapper.Map<TUpdateRequest, TEntity>(request, entity);
                    await unitOfWork.CommitAsync();
                }
            }

            return request;
        }
    }
}
