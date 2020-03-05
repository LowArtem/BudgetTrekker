using System;

namespace BudgetTrekker.Models
{
    public class ReportData
    {
        public int ID { get; set; }
        public DateTime Time { get; set; }
        public virtual IncomeData Income { get; set; }
        public virtual SpendingData Spending { get; set; }
        public BudgetData Budget { get; set; }
        public PreferenceData Preference { get; set; }
        public AccountData Account { get; set; }
        public bool IsIncome { get; set; } = false; // if false - spending


        public ReportData(DateTime time, IncomeData income, SpendingData spending, BudgetData budget, bool isIncome = false)
        {
            this.Time = time;
            this.Income = income;
            this.Spending = spending;
            this.IsIncome = isIncome;

            if (isIncome)
                this.Account = income.Account;
            else
                this.Account = spending.Account;

            this.Budget = budget;

            this.Preference = null;
        }

        public ReportData(DateTime time, IncomeData income, SpendingData spending, PreferenceData preference, bool isIncome = false)
        {
            this.Time = time;
            this.Income = income;
            this.Spending = spending;
            this.IsIncome = isIncome;

            if (isIncome)
                this.Account = income.Account;
            else
                this.Account = spending.Account;

            this.Preference = preference;

            this.Budget = null;
        }

        public ReportData(DateTime time, IncomeData income, SpendingData spending, bool isIncome = false)
        {
            this.Time = time;
            this.Income = income;
            this.Spending = spending;
            this.IsIncome = isIncome;

            if (isIncome)
                this.Account = income.Account;
            else
                this.Account = spending.Account;

            this.Preference = null;
            this.Budget = null;
        }

        public ReportData(DateTime time, IncomeData income, BudgetData budget)
        {
            this.IsIncome = true;
            this.Time = time;
            this.Income = income;
            this.Account = income.Account;
            this.Spending = null;
            this.Budget = budget;

            this.Preference = null;
        }

        public ReportData(DateTime time, IncomeData income, PreferenceData preference)
        {
            this.IsIncome = true;
            this.Time = time;
            this.Income = income;
            this.Account = income.Account;
            this.Spending = null;
            this.Preference = preference;

            this.Budget = null;
        }

        public ReportData(DateTime time, IncomeData income)
        {
            this.IsIncome = true;
            this.Time = time;
            this.Income = income;
            this.Account = income.Account;
            this.Spending = null;

            this.Budget = null;
            this.Preference = null;
        }

        public ReportData(DateTime time, SpendingData spending, BudgetData budget)
        {
            this.IsIncome = false;
            this.Time = time;
            this.Spending = spending;
            this.Account = spending.Account;
            this.Income = null;
            this.Budget = budget;

            this.Preference = null;
        }

        public ReportData(DateTime time, SpendingData spending, PreferenceData preference)
        {
            this.IsIncome = false;
            this.Time = time;
            this.Spending = spending;
            this.Account = spending.Account;
            this.Income = null;
            this.Preference = preference;

            this.Budget = null;
        }

        public ReportData(DateTime time, SpendingData spending)
        {
            this.IsIncome = false;
            this.Time = time;
            this.Spending = spending;
            this.Account = spending.Account;
            this.Income = null;

            this.Budget = null;
            this.Preference = null;
        }

        public ReportData() { }


        public string ReportCombine()
        {
            if (this.IsIncome) // income
            {                
                if (this.Budget != null)
                {
                    return "[" + this.Time.ToString("g") + "]: +" + this.Income.CurrentSum.ToString() + " руб на счет \"" +
                        this.Income.Account.Name + "\" из категории \"" + this.Income.Category + "\" из бюджет \"" + this.Budget.Name + "\"";
                }
                else if (this.Preference != null)
                {
                    return "[" + this.Time.ToString("g") + "]: +" + this.Income.CurrentSum.ToString() + " руб на счет \"" +
                        this.Income.Account.Name + "\" из категории \"" + this.Income.Category + "\" из предпочтения \"" + 
                        this.Preference.Name + "\"";
                }
                else
                {
                    return "[" + this.Time.ToString("g") + "]: +" + this.Income.CurrentSum.ToString() + " руб на счет \"" +
                        this.Income.Account.Name + "\" из категории \"" + this.Income.Category + "\"";
                }
            }
            else if (!this.IsIncome) // spending
            {
                if (this.Budget != null)
                {
                    return "[" + this.Time.ToString("g") + "]: -" + this.Spending.CurrentSum.ToString() + " руб со счета \"" +
                        this.Spending.Account.Name + "\" в категорию \"" + this.Spending.Category + "\" в бюджет \"" + 
                        this.Budget.Name + "\"";
                }
                else if (this.Preference != null)
                {
                    return "[" + this.Time.ToString("g") + "]: -" + this.Spending.CurrentSum.ToString() + " руб со счета \"" +
                        this.Spending.Account.Name + "\" в категорию \"" + this.Spending.Category + "\" в предпочтение \"" + 
                        this.Preference.Name + "\"";
                }
                else
                {
                    return "[" + this.Time.ToString("g") + "]: -" + this.Spending.CurrentSum.ToString() + " руб со счета \"" +
                        this.Spending.Account.Name + "\" в категорию \"" + this.Spending.Category + "\"";
                }
            }
            else // error
            {
                return "Error";
            }
        }
    }
}
