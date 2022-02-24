using adduo.elephant.domain.entities;
using adduo.elephant.repositories;
using System;
using System.Collections.Generic;

namespace adduo.elephant.test.services.scenarios
{
    public class DatabaseScenario : BaseScenario
    {
        public ElephantContext Create()
        {
            var installment = new domain.entities.debts.items.Installment(Guid.NewGuid(), "Teste", 100, 1, 1, 1, 2021, 3);
            SetMockDbSet<domain.entities.debts.items.Installment, Guid>(installment);

            var monthlyBundler = new domain.entities.debts.items.MonthlyBundler(Guid.NewGuid(), "Teste", 10, 1, 2);
            SetMockDbSet<domain.entities.debts.items.MonthlyBundler, Guid>(monthlyBundler);

            var monthly = new domain.entities.debts.items.Monthly(Guid.NewGuid(), "Teste", 10, 1, 2);
            SetMockDbSet<domain.entities.debts.items.Monthly, Guid>(monthly);

            var pontual = new domain.entities.debts.items.Pontual(Guid.NewGuid(), "Teste", 100, 1, 1, 1, 2021);
            SetMockDbSet<domain.entities.debts.items.Pontual, Guid>(pontual);

            var yearly = new domain.entities.debts.items.Yearly(Guid.NewGuid(), "Teste", 10, 1, 2, 3);
            SetMockDbSet<domain.entities.debts.items.Yearly, Guid>(yearly);

            var installmentBundler = new domain.entities.debts.bundler_items.Installment(Guid.NewGuid(), "Teste", 100);
            SetMockDbSet<domain.entities.debts.bundler_items.Installment, Guid>(installmentBundler);

            var bundlerMonthly = new domain.entities.debts.bundler_items.Monthly(Guid.NewGuid(), "Teste", 10);
            SetMockDbSet<domain.entities.debts.bundler_items.Monthly, Guid>(bundlerMonthly);

            var pontualBundler = new domain.entities.debts.bundler_items.Pontual(Guid.NewGuid(), "Teste", 100, 1, 2021);
            SetMockDbSet<domain.entities.debts.bundler_items.Pontual, Guid>(pontualBundler);

            var yearlyBundler = new domain.entities.debts.bundler_items.Yearly(Guid.NewGuid(), "Teste", 10, 1);
            SetMockDbSet<domain.entities.debts.bundler_items.Yearly, Guid>(yearlyBundler);

            var tags = new List<Tag>
            {
                new Tag(1, "AAAAA"),
                new Tag(2, "BBBBB"),
                new Tag(3, "BBBBB")
            };
            SetMockDbSet<Tag, int>(tags);

            return context.Object;
        }
    }
}
