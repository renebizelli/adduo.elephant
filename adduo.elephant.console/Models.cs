using System;
using System.Collections.Generic;
using System.Linq;

namespace adduo.elephant.console
{

    public class Group
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Group(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Payer
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Payer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public enum DebtStatuses
    {
        Active,
        Inactive
    }

    public enum SheetItemStatuses
    {
        Pending,
        Payed
    }


    abstract public class BaseDebt
    {
        public Guid Id { get; private set; }
        public string Description { get; private set; }
        public double Value { get; protected set; }
        public int CategoryId { get; private set; }
        public Category Category { get; private set; }
        public DebtStatuses Status { get; private set; }

        protected BaseDebt(string description, double value, Category category)
        {
            Id = Guid.NewGuid();
            Description = description;
            Value = value;
            Category = category;
            CategoryId = category.Id;
            Status = DebtStatuses.Active;
        }
    }

    abstract public class Debt : BaseDebt
    {
        public Payer Payer { get; private set; }
        public Group Group { get; private set; }
        public int DueDay { get; private set; }

        protected Debt(string description, double value, int dueDay, Payer payer, Group group, Category category) : base(description, value, category)
        {
            Payer = payer;
            Group = group;
            DueDay = dueDay;
        }

        public override string ToString()
        {
            return $"{Group.Name} {Description} - {DueDay} - {Value}";
        }
    }

    abstract public class BaseBundlerItemDebt : BaseDebt
    {
        protected BaseBundlerItemDebt(string description, double value, Category category) : base(description, value, category)
        {
        }
    }

    public class PontualBundlerItemDebt : BaseBundlerItemDebt
    {
        public PontualBundlerItemDebt(string description, double value, int month, int year, Category category) : base(description,  value, category)
        {
            Month = month;
            Year = year;
        }

        public int Month { get; private set; }
        public int Year { get; private set; }
    }

    public class MonthlyRecurrenceBundlerItemDebt : BaseBundlerItemDebt
    {
        public MonthlyRecurrenceBundlerItemDebt(string description,  double value, Category category) : base(description,  value, category)
        { }
    }

    public class InstallmentsBundlerItemDebt : BaseBundlerItemDebt
    {
        public int StartMonth { get; private set; }
        public int StartYear { get; private set; }
        public int Installments { get; private set; }
        public DateTime EndAt { get; private set; }

        public InstallmentsBundlerItemDebt(string description, double value, int startMonth, int startYear, int installments, Category category) : base(description, value, category)
        {
            StartMonth = startMonth;
            StartYear = startYear;
            Installments = installments;

            EndAt = (new DateTime(startYear, startMonth, 1)).AddMonths(installments);
        }

        public int CurrentInstallment(int month, int year)
        {
            var startedDate = new DateTime(StartYear, StartMonth, 1);
            var date = new DateTime(year, month, 1);

            var installments = startedDate.GetMonthDifference(date);

            return installments;
        }

        public override string ToString()
        {
            var _base = base.ToString();

            return $"{_base} {StartMonth}/{StartYear} - {CurrentInstallment(DateTime.Now.Month, DateTime.Now.Year)}";
        }
    }

    public class YearlyRecurrenceBundlerItemDebt : BaseBundlerItemDebt
    {
        public int DueMonth { get; private set; }

        public YearlyRecurrenceBundlerItemDebt(string description, Category category, double value, int dueMonth) : base(description, value, category)
        {
            DueMonth = dueMonth;
        }

        public override string ToString()
        {
            var _base = base.ToString();

            return $"{_base} {DueMonth}";
        }
    }

    public class PontualDebt : Debt
    {
        public PontualDebt(string description, double value, int dueDay, int month, int year, Payer payer, Group group, Category category) : base(description, value, dueDay, payer, group, category)
        {
            Month = month;
            Year = year;
        }

        public int Month { get; private set; }
        public int Year { get; private set; }
    }

    public class MonthlyRecurrenceDebt : Debt
    {
        public MonthlyRecurrenceDebt(string description, double value, int dueDay,  Payer payer, Group group, Category category) : base(description, value, dueDay, payer, group, category)
        { }
    }

    public class YearlyRecurrenceDebt : Debt
    {
        public int DueMonth { get; private set; }

        public YearlyRecurrenceDebt(string description, double value, int dueDay, int dueMonth, Payer payer, Group group, Category category) : base(description, value, dueDay, payer, group, category)
        {
            DueMonth = dueMonth;
        }

        public override string ToString()
        {
            var _base = base.ToString();

            return $"{_base} {DueMonth}";
        }
    }

    public class InstallmentsDebt : Debt
    {
        public int StartMonth { get; private set; }
        public int StartYear { get; private set; }
        public int Installments { get; private set; }
        public DateTime EndAt { get; private set; }

        public InstallmentsDebt(string description,  double value, int dueDay, int startMonth, int startYear, int installments, Payer payer, Group group, Category category) : base(description, value, dueDay, payer, group, category)
        {
            StartMonth = startMonth;
            StartYear = startYear;
            Installments = installments;

            EndAt = (new DateTime(startYear, startMonth, dueDay)).AddMonths(installments);
        }

        public int CurrentInstallment(int month, int year)
        {
            var startedDate = new DateTime(StartYear, StartMonth, DueDay);
            var date = new DateTime(year, month, DueDay);

            var installments = startedDate.GetMonthDifference(date);

            return installments;
        }

        public override string ToString()
        {
            var _base = base.ToString();

            return $"{_base} {StartMonth}/{StartYear} - {CurrentInstallment(DateTime.Now.Month, DateTime.Now.Year)}";
        }
    }

    public class MonthlyBlunderDebt : Debt
    {
        public List<BaseBundlerItemDebt> Debts { get; private set; } = new List<BaseBundlerItemDebt>();

        public MonthlyBlunderDebt(string description, int dueDay,  Payer payer, Group group, Category category) : base(description, 0, dueDay, payer, group, category)
        {
        }

        public void AddDebt(BaseBundlerItemDebt debt)
        {
            this.Debts.Add(debt);
            Value = Debts.Sum(s => s.Value);
        }
    }

    public class SheetItem 
    {
        public Guid Id { get; set; }
        public Debt Debt { get; private set; }
        public Guid SheetId { get; private set; }

        public double CurrentValue { get; private set; }
        public double PayedValue { get; private set; }
        public SheetItemStatuses Status { get; private set; }
        public SheetItem(Debt debt, Sheet sheet)
        {
            Id = Guid.NewGuid();
            Debt = debt;
            SheetId = sheet.Id;
            CurrentValue = debt.Value;
        }
    }


    public class Sheet
    {
        public Guid Id { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }
        public List<SheetItem> Items { get; private set; } = new List<SheetItem>();

        public DateTime CreatedAt { get; private set; }
        public Sheet(int month, int year)
        {
            Id = Guid.NewGuid();
            Month = month;
            Year = year;
        }

    }






}
