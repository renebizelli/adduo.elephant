using System.Collections.Generic;

namespace adduo.elephant.console
{
    public class Db
    {
        public List<Debt> Debts { get; set; }
        public List<Sheet> Sheets { get; set; }
        public List<SheetItem> SheetItems { get; set; }
        public Db()
        {
            var categories = new List<Category>
            {
                new Category (1, "Pais"),
                new Category (2, "Unique"),
                new Category (3, "Reservas"),
                new Category (4, "Avuslo"),
                new Category (5, "Adduo"),
                new Category (6, "Cartão"),
            };

            var payers = new List<Payer>
            {
                new Payer(1, "Conta bancária"),
                new Payer(2, "VR")
            };

            var groups = new List<Group>
            {
                new (1, "Contas"),
                new Group(2, "Cartão de crédito")
            };

            var monthlyBlunderDebt = new MonthlyBlunderDebt("Nubank", 12, payers[0], groups[0], categories[5]);
            monthlyBlunderDebt.AddDebt(new MonthlyRecurrenceBundlerItemDebt("cc mesada", 865, categories[0]));
            monthlyBlunderDebt.AddDebt(new PontualBundlerItemDebt("cc aaaaaaa", 123, 4, 2022, categories[0]));
            monthlyBlunderDebt.AddDebt(new MonthlyRecurrenceBundlerItemDebt("cc hhhhh", 357, categories[2]));
            monthlyBlunderDebt.AddDebt(new InstallmentsBundlerItemDebt("cc ttttttt",  254, 5, 2022, 6, categories[4]));

            Debts = new List<Debt>
            {
                new MonthlyRecurrenceDebt("mesada", 865, 7,  payers[0], groups[0], categories[1]),
                new InstallmentsDebt("consignado", 81, 7, 3, 2015, 74,  payers[0], groups[0], categories[1]),
                new MonthlyRecurrenceDebt("plano de saúde",  774.67, 28, payers[0], groups[0], categories[1]),
                new MonthlyRecurrenceDebt("aluguel", 1469.70, 8, payers[0], groups[0], categories[1]),
                new PontualDebt("aaaaaaa", 012, 3, 4, 2022, payers[0], groups[0],  categories[0]),
                new PontualDebt("bbbbbb", 123, 9, 4, 2022, payers[0], groups[0], categories[1]),
                new PontualDebt("cccccc", 456, 15, 4, 2022, payers[0], groups[0], categories[2]),
                new PontualDebt("dddddd", 789, 20, 4, 2022, payers[0], groups[0], categories[3]),
                new PontualDebt("eeeeeee", 147, 24, 5, 2022, payers[0], groups[0], categories[4]),
                new PontualDebt("fffffff", 258, 28, 5, 2022, payers[0], groups[0],  categories[0]),
                new MonthlyRecurrenceDebt("hhhhh", 357, 25, payers[0], groups[0], categories[2]),
                new MonthlyRecurrenceDebt("iii", 147, 22, payers[0], groups[0], categories[3]),
                new MonthlyRecurrenceDebt("jjjjjj", 369, 19, payers[0], groups[0], categories[4]),
                new MonthlyRecurrenceDebt("kkkkk", 258, 13, payers[0], groups[0],  categories[0]),
                new MonthlyRecurrenceDebt("llllll", 741, 8, payers[0], groups[0], categories[1]),
                new MonthlyRecurrenceDebt("mmmmmmmm", 852, 2, payers[0], groups[0], categories[2]),
                new YearlyRecurrenceDebt("nnnnnn", 145, 2, 6, payers[0], groups[0], categories[3]),
                new YearlyRecurrenceDebt("ooooooo", 256, 23, 7, payers[0], groups[0], categories[4]),
                new YearlyRecurrenceDebt("pppppp", 365, 27, 7, payers[0], groups[0],  categories[0]),
                new InstallmentsDebt("qqqqqqq", 478, 27, 11, 2021, 3, payers[0], groups[0], categories[1]),
                new InstallmentsDebt("rrrrrrr", 589, 15, 4, 2022, 4, payers[0], groups[0], categories[2]),
                new InstallmentsDebt("ssssss", 587, 15, 5, 2022, 2, payers[0], groups[0], categories[3]),
                new InstallmentsDebt("ttttttt", 254, 15, 5, 2022, 6, payers[0], groups[0], categories[4]),
                monthlyBlunderDebt
            };

            Sheets = new List<Sheet>
            {
                new Sheet(1, 2022),
                new Sheet(12, 2021),
                new Sheet(11, 2021),
                new Sheet(10, 2021),
            };

            SheetItems = new List<SheetItem>();
            Debts.ForEach(f => SheetItems.Add(new SheetItem(f, Sheets[0])));
        }
    }
}
