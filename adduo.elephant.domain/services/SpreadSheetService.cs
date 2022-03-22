using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.contracts.services.queries;
using adduo.elephant.domain.entities;
using adduo.elephant.domain.requests;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adduo.elephant.domain.services
{
    public class SpreadSheetService : ISpreadSheetService
    {
        private readonly ISpreadSheetRepository repository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IQueryService<entities.debts_template.BundlerMonthlyTemplate> bundlerMonthlyTemplateQuery;
        private readonly IQueryService<entities.debts_template.InstallmentTemplate> installmentTemplateQuery;
        private readonly IQueryService<entities.debts_template.MonthlyTemplate> monthlyTemplateQuery;
        private readonly IQueryService<entities.debts_template.PontualTemplate> pontualTemplateQuery;
        private readonly IQueryService<entities.debts_template.RecurrentTemplate> recurrentTemplateQuery;
        private readonly IQueryService<entities.debts_template.YearlyTemplate> yearlyTemplateQuery;

        public SpreadSheetService(
            ISpreadSheetRepository repository,
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IQueryService<entities.debts_template.BundlerMonthlyTemplate> bundlerMonthlyTemplateQuery,
            IQueryService<entities.debts_template.InstallmentTemplate> installmentTemplateQuery,
            IQueryService<entities.debts_template.MonthlyTemplate> monthlyTemplateQuery,
            IQueryService<entities.debts_template.PontualTemplate> pontualTemplateQuery,
            IQueryService<entities.debts_template.RecurrentTemplate> recurrentTemplateQuery,
            IQueryService<entities.debts_template.YearlyTemplate> yearlyTemplateQuery)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

            this.bundlerMonthlyTemplateQuery = bundlerMonthlyTemplateQuery;
            this.installmentTemplateQuery = installmentTemplateQuery;
            this.monthlyTemplateQuery = monthlyTemplateQuery;
            this.pontualTemplateQuery = pontualTemplateQuery;
            this.recurrentTemplateQuery = recurrentTemplateQuery;
            this.yearlyTemplateQuery = yearlyTemplateQuery;
        }

        public async Task<dtos.SpreadSheet> GetAsync(PeriodRequest period)
        {
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

            //var bundlerMonthlies = await bundlerMonthlyTemplateQuery.Get(period);
            //AddItems(spreadsheet, bundlerMonthlies);

            //var installments = await installmentTemplateQuery.Get(period);
            //AddItems(spreadsheet, installments);

            //var monthlies = await monthlyTemplateQuery.Get(period);
            //AddItems<entities.debts_template.Monthly>(spreadsheet, monthlies);

            //var pontuals = await pontualTemplateQuery.Get(period);
            //AddItems<entities.debts_template.Pontual>(spreadsheet, pontuals);

            //var yearlies = await yearlyTemplateQuery.Get(period);
            //AddItems<entities.debts_template.Yearly>(spreadsheet, yearlies);


            await repository.SaveAsync(spreadsheet);

            await unitOfWork.CommitAsync();

            return spreadsheet;
        }

        //private void AddItems(SpreadSheet spreadSheet, List<entities.debts_template.BundlerMonthly> items)
        //{
        //    foreach (var item in items)
        //    {
        //        var itemsAmountBundler = new List<entities.debts.bundler_items.ItemAmountBundler>();

        //        itemsAmountBundler.AddRange(item.Items.OfType<entities.debts.bundler_items.InstallmentBundler>());
        //        itemsAmountBundler.AddRange(item.Items.OfType<entities.debts.bundler_items.MonthlyBundler>());
        //        itemsAmountBundler.AddRange(item.Items.OfType<entities.debts.bundler_items.PontualBundler>());
        //        itemsAmountBundler.AddRange(item.Items.OfType<entities.debts.bundler_items.YearlyBundler>());

        //        foreach (var bundler in itemsAmountBundler)
        //        {
        //            AddItemBundler(spreadSheet, bundler, bundler.Amount);
        //        }

        //        var itemsBundler = new List<entities.debts.bundler_items.ItemBundler>();

        //        itemsBundler.AddRange(item.Items.OfType<entities.debts.bundler_items.RecurrentBundler>());

        //        foreach (var bundler in itemsBundler)
        //        {
        //            AddItemBundler(spreadSheet, bundler);
        //        }

        //        AddItem(spreadSheet, item, 0);
        //    }
        //}


        //private void AddItems(SpreadSheet spreadSheet, List<entities.debts_template.InstallmentTemplate> items)
        //{
        //    foreach (var item in items)
        //    {
        //        AddItem(spreadSheet, item, item.GetInstallmentValue());
        //    }
        //}

        //private void AddItems<T>(SpreadSheet spreadSheet, List<T> items)
        //    where T : entities.debts_template.ItemAmount
        //{
        //    foreach (var item in items)
        //    {
        //        AddItem(spreadSheet, item, item.Amount);
        //    }
        //}

        //private void AddItem<T>(SpreadSheet spreadSheet, T item, decimal amount) where T : entities.debts_template.Item
        //{
        //    var spreadSheetItem = new SpreadSheetItem(amount, 0);
        //    spreadSheetItem.Debt = item;
        //    spreadSheetItem.DebtId = item.Id;

        //    spreadSheet.Items.Add(spreadSheetItem);
        //}


    }
}
