﻿using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.services
{
    public class DebtService<TRequest, TEntity> : IDebtService<TRequest, TEntity>
                where TRequest : DebtRequest
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

        public async Task<TRequest> SaveAsync(TRequest request)
        {
            request.Validate();

            if(request.AllFieldsAreValid())
            {
                request.Id = Guid.NewGuid();

                var entity = mapper.Map<TEntity>(request);

                entity.Activate();

                await repository.SaveAsync(entity);

                await unitOfWork.CommitAsync();
            }

            return request;
        }

        public async Task<TRequest> UpdateAsync(string id, TRequest request)
        {
            var guid = Guid.Empty;

            if(!Guid.TryParse(id, out guid))
            {
                throw new ArgumentException("id");
            }

            request.Validate();

            if (request.AllFieldsAreValid())
            {
                request.Id = guid;

                var entity = mapper.Map<TEntity>(request);

                entity.Activate();

                repository.Update(entity);

                await unitOfWork.CommitAsync();
            }

            return request;
        }
    }
}