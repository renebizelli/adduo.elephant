using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.entities;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.mappers;
using adduo.elephant.domain.mappers.resolvers;
using adduo.elephant.domain.requests;
using adduo.elephant.domain.services;
using AutoMapper;
using Moq;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.test.services
{
    public class DebtServiceTest<TRequest, TEntity, TProfile>
        where TRequest : DebtRequest
        where TEntity : Debt
        where TProfile : Profile
    {
        private readonly IMapper mapper;

        public DebtServiceTest()
        {
            var tagRepository = new Mock<IItemRepository<Tag, int>>();

            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DebtProfile());
                cfg.AddProfile(new ItemDebtProfile());
                cfg.AddProfile(Activator.CreateInstance<TProfile>());
            });
            mapper = mockMapper.CreateMapper();
        }

        public async Task ShoudCallMethodsWhenCallSaveBase(Mock<TRequest> request)
        {
            request.Setup(s => s.AllFieldsAreValid()).Returns(true);

            var repository = new Mock<IDebtRepository<TEntity>>();
            repository.Setup(s => s.SaveAsync(It.IsAny<TEntity>())).Returns(Task.CompletedTask);

            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(s => s.CommitAsync()).Returns(Task.CompletedTask);

            var service = new DebtService<TRequest, TEntity>(mapper, repository.Object, unitOfWork.Object);
            await service.SaveAsync(request.Object);

            request.Verify(v => v.Validate(), Times.Once());
            request.Verify(v => v.AllFieldsAreValid(), Times.Once());
            repository.Verify(v => v.SaveAsync(It.IsAny<TEntity>()), Times.Once());
            unitOfWork.Verify(v => v.CommitAsync(), Times.Once());
        }
    }
}
