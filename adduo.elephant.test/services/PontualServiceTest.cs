
using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.entities;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.mappers;
using adduo.elephant.domain.services;
using adduo.elephant.repositories;
using adduo.elephant.repositories.access;
using adduo.elephant.test.requests;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace adduo.elephant.test.services
{
    public class PontualServiceTest
    {
        //private readonly Mock<ElephantContext> mockContext;
        private readonly IMapper mapper;

        public PontualServiceTest()
        {
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new PontualItemDebtProfile());
            });
            mapper = mockMapper.CreateMapper();
        }

        [Fact]
        public async void ItsShoudSavePontualDebt()
        {
            var mockContext = new Mock<ElephantContext>();

            var mockSet = new Mock<DbSet<PontualItemDebt>>();
            mockContext.Setup(m => m.PontualItemDebts).Returns(mockSet.Object);

            var repository = new DebtAccess<PontualItemDebt>(mockContext.Object);

            var unitOfWork =  new Mock<IUnitOfWork>();

            var service = new PontualService(mapper, repository, unitOfWork.Object);

            var request = PontualItemDebtRequestTest.GenerateValidRequest();

            await service.SaveAsync(request);

            //mockSet.Verify(m => m.Add(It.IsAny<PontualItemDebt>()), Times.Once());
            //mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}
