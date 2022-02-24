using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.entities;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using adduo.elephant.domain.services;
using adduo.elephant.repositories;
using adduo.elephant.repositories.access;
using adduo.elephant.test.services.scenarios;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace adduo.elephant.test.services.debts
{
    public class DebtServiceTest<TRequest, TEntity, TProfile>
        where TRequest : DebtRequest
        where TEntity : Debt
        where TProfile : Profile
    {
        private readonly IMapper mapper;
        protected readonly ElephantContext context;

        public DebtServiceTest()
        {
            IServiceCollection services = new ServiceCollection();

            var tagRepositoryMock = Mock.Of<IItemRepository<Tag, int>>(_ =>
                _.Get(It.IsAny<int>()) == new Tag(3)
            );

            services.AddTransient<IItemRepository<Tag, int>>(sp => tagRepositoryMock);

            services.AddAutoMapper(typeof(domain.mappers.debts.DebtProfile));
            services.AddAutoMapper(typeof(domain.mappers.debts.items.ItemProfile));
            services.AddAutoMapper(typeof(domain.mappers.debts.items.ItemAmountProfile));
            services.AddAutoMapper(typeof(domain.mappers.debts.bundler_items.ItemProfile));
            services.AddAutoMapper(typeof(TProfile));

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            mapper = serviceProvider.GetService<IMapper>();
            
            context = new DatabaseScenario().Create();
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

        public async Task ShoudCallMethodsWhenCallUpdateBase(string id, Mock<TRequest> request)
        {
            request.Setup(s => s.AllFieldsAreValid()).Returns(true);

            var repository = new Mock<IDebtRepository<TEntity>>();
            repository.Setup(s => s.GetAsync(It.IsAny<Guid>())).Returns(Task.FromResult(Activator.CreateInstance<TEntity>()));

            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(s => s.CommitAsync()).Returns(Task.CompletedTask);

            var service = new DebtService<TRequest, TEntity>(mapper, repository.Object, unitOfWork.Object);
            await service.UpdateAsync(id, request.Object);

            request.Verify(v => v.Validate(), Times.Once());
            request.Verify(v => v.AllFieldsAreValid(), Times.Once());
            repository.Verify(v => v.GetAsync(It.IsAny<Guid>()), Times.Once());
            unitOfWork.Verify(v => v.CommitAsync(), Times.Once());
        }

        public async Task ShoudUpdateEntityBase(string id, TRequest request)
        {
            var repository = new DebtAccess<TEntity>(context);

            var unitOfWork = new UnitOfWork(context);

            var service = new DebtService<TRequest, TEntity>(mapper, repository, unitOfWork);
            await service.UpdateAsync(id, request);
        }

        protected void DebtAssert(DebtRequest request, Debt entity)
        {
            Assert.Equal(request.Name.Value, entity.Name);
            Assert.Equal(DebtStatuses.Active, entity.Status);
            Assert.Equal(request.Tags.Value.Count, entity.Tags.Count);
            Assert.Equal(request.Tags.Value.First(), entity.Tags.Select(s=>s.Id).First());
        }

        protected void ItemAssert(domain.requests.debts.items.ItemRequest request, domain.entities.debts.items.Item entity)
        {
            Assert.Equal(request.DueDayOfMonth.GetValue(), entity.DueDay);
            Assert.Equal(request.InComeId.GetValue(), entity.InComeId);
        }

        protected void ItemAmountAssert(domain.requests.debts.items.ItemAmountRequest request, domain.entities.debts.items.ItemAmount entity)
        {
            Assert.Equal(request.Value.GetValue(), entity.Amount);
        }

        protected void ItemAssert(domain.requests.debts.bundler_items.ItemRequest request, domain.entities.debts.bundler_items.Item entity)
        {
            Assert.Equal(request.Value.GetValue(), entity.Amount);
            Assert.Equal(request.BundlerMonthly.GetValue(), entity.BundlerMonthlyId);
        }
    }
}
