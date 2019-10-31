namespace BudgetTrekker.Models
{
    public class Data
    {
        public int ID { get; set; }
        public virtual BudgetData Budgets { get; set; }
        public virtual PreferenceData Preferences { get; set; }
        public virtual AccountData Accounts { get; set; }
        public virtual IncomeData Income { get; set; }
        public virtual SpendingData Spendings { get; set; }
        public virtual ReportData Report { get; set; }
        public virtual CalendarData Calendar { get; set; }


        public Data(BudgetData budget, PreferenceData preference, AccountData account, IncomeData income, SpendingData spending, ReportData report, CalendarData calendar)
        {
            this.Budgets = budget;
            this.Preferences = preference;
            this.Accounts = account;
            this.Income = income;
            this.Spendings = spending;
            this.Report = report;
            this.Calendar = calendar;
        }

        public Data() { }
    }
}
