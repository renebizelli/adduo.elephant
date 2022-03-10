using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.contracts.services.queries;
using adduo.elephant.domain.entities;
using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.requests;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace adduo.elephant.domain.services
{
    public class SpreadSheetService : ISpreadSheetService
    {
        private readonly ISpreadSheetRepository repository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IQueryService<Pontual> pontualQuery;
        private readonly IQueryService<Monthly> monthlyQuery;
        private readonly IQueryService<Yearly> yearlyQuery;
        private readonly IQueryService<Installment> installmentQuery;

        public SpreadSheetService(
            ISpreadSheetRepository repository,
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IQueryService<Pontual> pontualQuery,
            IQueryService<Monthly> monthlyQuery,
            IQueryService<Yearly> yearlyQuery,
            IQueryService<Installment> installmentQuery)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.pontualQuery = pontualQuery;
            this.monthlyQuery = monthlyQuery;
            this.yearlyQuery = yearlyQuery;
            this.installmentQuery = installmentQuery;
        }

        public async Task<dtos.SpreadSheet> GetAsync(PeriodRequest period)
        {

            await pontualQuery.Get(period);

            period.ThrowIfInvalid();

            var entity = await this.repository.GetAsync(period);

            if (entity == null)
            {
                entity = await CreateAsync(period);
            }

            var dto = mapper.Map<dtos.SpreadSheet>(entity);

            return dto;
        }

        private async Task<SpreadSheet> CreateAsync(PeriodRequest period)
        {
            var spreadsheet = new SpreadSheet(period.Year, period.Month);

            var pontuals = await pontualQuery.Get(period);
            AddItems<Pontual>(spreadsheet, pontuals);

            var monthlies = await monthlyQuery.Get(period);
            AddItems<Monthly>(spreadsheet, monthlies);

            var yearlies = await yearlyQuery.Get(period);
            AddItems<Yearly>(spreadsheet, yearlies);

            var installments = await installmentQuery.Get(period);
            AddItems<Installment>(spreadsheet, installments);

            //await repository.SaveAsync(spreadsheet);

            //await unitOfWork.CommitAsync();

            return spreadsheet;
        }

        private void AddItems<T>(SpreadSheet spreadSheet, List<T> items)
            where T : ItemAmount
        {
            foreach (var item in items)
            {
                var spreadSheetItem = new SpreadSheetItem(item.Amount, 0);
                spreadSheetItem.Debt = item;
                spreadSheetItem.DebtId = item.Id;

                spreadSheet.Items.Add(spreadSheetItem);
            }
        }
    }
}
