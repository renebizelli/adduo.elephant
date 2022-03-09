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
using System.Threading.Tasks;
using Xunit;

namespace adduo.elephant.test.services.debts
{
    public class DebtServiceTest<TSaveRequest, TEntity, TProfile> : DebtServiceTest<TSaveRequest, TSaveRequest, TEntity, TProfile>
        where TSaveRequest : DebtRequest
        where TEntity : Debt
        where TProfile : Profile
    {

    }

    public class DebtServiceTest<TSaveRequest, TUpdateRequest, TEntity, TProfile>
        where TSaveRequest : DebtRequest
        where TUpdateRequest : DebtRequest
        where TEntity : Debt
        where TProfile : Profile
    {
        private readonly IMapper mapper;
        protected readonly ElephantContext context;

        public DebtServiceTest()
        {
            IServiceCollection services = new ServiceCollection();

            var tagRepositoryMock = Mock.Of<IItemRepository<Category, int>>(_ =>
                _.Get(It.IsAny<int>()) == new Category(3)
            );

            services.AddTransient<IItemRepository<Category, int>>(sp => tagRepositoryMock);

            services.AddAutoMapper(typeof(domain.mappers.debts.DebtProfile));
            services.AddAutoMapper(typeof(domain.mappers.debts.items.ItemProfile));
            services.AddAutoMapper(typeof(domain.mappers.debts.items.ItemAmountProfile));
            services.AddAutoMapper(typeof(domain.mappers.debts.bundler_items.ItemBundlerProfile));
            services.AddAutoMapper(typeof(TProfile));

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            mapper = serviceProvider.GetService<IMapper>();
            
            context = new DatabaseScenario().Create();
        }

        public async Task ShoudCallMethodsWhenCallSaveBase(Mock<TSaveRequest> request)
        {
            request.Setup(s => s.AllFieldsAreValid()).Returns(true);

            var repository = new Mock<IDebtRepository<TEntity>>();
            repository.Setup(s => s.SaveAsync(It.IsAny<TEntity>())).Returns(Task.CompletedTask);

            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(s => s.CommitAsync()).Returns(Task.CompletedTask);

            var service = new DebtService<TSaveRequest, TEntity>(mapper, repository.Object, unitOfWork.Object);
            await service.SaveAsync(request.Object);

            request.Verify(v => v.Validate(), Times.Once());
            request.Verify(v => v.AllFieldsAreValid(), Times.Once());
            repository.Verify(v => v.SaveAsync(It.IsAny<TEntity>()), Times.Once());
            unitOfWork.Verify(v => v.CommitAsync(), Times.Once());
        }

        public async Task ShoudCallMethodsWhenCallUpdateBase(string id, Mock<TUpdateRequest> request)
        {
            request.Setup(s => s.AllFieldsAreValid()).Returns(true);

            var repository = new Mock<IDebtRepository<TEntity>>();
            repository.Setup(s => s.GetAsync(It.IsAny<Guid>())).Returns(Task.FromResult(Activator.CreateInstance<TEntity>()));

            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(s => s.CommitAsync()).Returns(Task.CompletedTask);

            var service = new DebtService<TUpdateRequest, TEntity>(mapper, repository.Object, unitOfWork.Object);
            await service.UpdateAsync(id, request.Object);

            request.Verify(v => v.Validate(), Times.Once());
            request.Verify(v => v.AllFieldsAreValid(), Times.Once());
            repository.Verify(v => v.GetAsync(It.IsAny<Guid>()), Times.Once());
            unitOfWork.Verify(v => v.CommitAsync(), Times.Once());
        }

        public async Task ShoudUpdateEntityBase(string id, TUpdateRequest request)
        {
            var repository = new DebtRepository<TEntity>(context);

            var unitOfWork = new UnitOfWork(context);

            var service = new DebtService<TUpdateRequest, TEntity>(mapper, repository, unitOfWork);
            await service.UpdateAsync(id, request);
        }

        protected void DebtAssert(DebtRequest request, Debt entity)
        {
            Assert.Equal(request.Name.Value, entity.Name);
            Assert.Equal(DebtStatuses.Active, entity.Status);
            Assert.Equal(request.CategoryId.GetValue(), entity.CategoryId);
        }

        protected void ItemAssert(domain.requests.debts.items.ItemRequest request, domain.entities.debts.items.Item entity)
        {
            Assert.Equal(request.DueDayOfMonth.GetValue(), entity.DueDay);
            Assert.Equal(request.InComeId.GetValue(), entity.InComeId);
        }

        protected void ItemAmountAssert(domain.requests.debts.items.ItemAmountRequest request, domain.entities.debts.items.ItemAmount entity)
        {
            Assert.Equal(request.Amount.GetValue(), entity.Amount);
        }

        protected void ItemAssert(domain.requests.debts.bundler_items.ItemBundlerRequest request, domain.entities.debts.bundler_items.ItemBundler entity)
        {
            Assert.Equal(request.BundlerMonthly.GetValue(), entity.BundlerMonthlyId);
        }

        protected void ItemAmountAssert(domain.requests.debts.bundler_items.ItemAmountBundlerRequest request, domain.entities.debts.bundler_items.ItemAmountBundler entity)
        {
            Assert.Equal(request.Amount.GetValue(), entity.Amount);
        }
    }
}
