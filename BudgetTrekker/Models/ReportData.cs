using System;

namespace BudgetTrekker.Models
{
    public class ReportData
    {
        public int ID { get; set; }
        public DateTime Time { get; set; }
        public virtual IncomeData Income { get; set; }
        public virtual SpendingData Spending { get; set; }
        public bool IsIncome { get; set; } = false; // if false - spending


        public ReportData(DateTime time, IncomeData income, SpendingData spending, bool isIncome = false)
        {
            this.Time = time;
            this.Income = income;
            this.Spending = spending;
            this.IsIncome = isIncome;
        }

        public ReportData() { }

        public string ReportCombiner()
        {
            if (this.IsIncome)
            {
                return "[" + this.Time.ToString("g") + "]: +" + this.Income.CurrentSum.ToString() + " руб на счет \"" +
                    this.Income.Account.Name + "\" из категории \"" + this.Income.Category + "\"";
            }
            else if (!this.IsIncome)
            {
                return "[" + this.Time.ToString("g") + "]: -" + this.Spending.CurrentSum.ToString() + " руб со счета \"" +
                    this.Spending.Account.Name + "\" в категорию \"" + this.Spending.Category + "\"";
            }
            else
            {
                return "Error";
            }
        }
    }
}
