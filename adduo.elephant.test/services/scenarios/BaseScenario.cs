using adduo.elephant.domain.entities;
using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace adduo.elephant.test.services.scenarios
{
    public abstract class BaseScenario
    {
        protected Mock<ElephantContext> context { get; }

        public BaseScenario()
        {
            context = new Mock<ElephantContext>();
        }

        protected void SetMockDbSet<T, TId>(List<T> list)
            where T : Entity<TId>
        {
            foreach (var item in list)
            {
                SetMockDbSet<T, TId>(item);
            }
        }

        protected void SetMockDbSet<T, TId>(T entity)
            where T : Entity<TId>
        {

            var source = new List<T> { entity };
            var data = source.AsQueryable();

            var mockSet = new Mock<DbSet<T>>();
            mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(new TestAsyncQueryProvider<T>(data.Provider));
            mockSet.As<IAsyncEnumerable<T>>().Setup(m => m.GetAsyncEnumerator(default)).Returns(new TestAsyncEnumerator<T>(data.GetEnumerator()));

            context.Setup(c => c.Set<T>()).Returns(mockSet.Object);
        }
    }
}
