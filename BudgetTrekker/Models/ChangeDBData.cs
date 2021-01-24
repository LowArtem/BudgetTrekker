using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrekker.Models
{
    static class ChangeDBData
    {
        public static void Change(int id, AccountData data)
        {
            ChangeDBData.ChangeAccount(id, data);
        }

        #region Change overloads
        public static void Change(int id, BudgetData data)
        {
            ChangeDBData.ChangeBudget(id, data);
        }

        public static void Change(int id, CalendarData data)
        {
            ChangeDBData.ChangeCalendar(id, data);
        }

        public static void Change(int id, IncomeData data)
        {
            ChangeDBData.ChangeIncome(id, data);
        }

        public static void Change(int id, SpendingData data)
        {
            ChangeDBData.ChangeSpending(id, data);
        }

        public static void Change(int id, ReportData data)
        {
            ChangeDBData.ChangeReports(id, data);
        }

        public static void Change(int id, PreferenceData data)
        {
            ChangeDBData.ChangePreferences(id, data);
        }
        #endregion

        private static void ChangeAccount(int id, AccountData new_account)
        {
            var db = new DbManager();
            var data = db.Accounts.ToList();

            foreach (var data_element in data)
            {
                if (data_element.ID == id)
                {
                    data_element.CardNumber = new_account.CardNumber;
                    data_element.CashSum = new_account.CashSum;
                    data_element.Index = new_account.Index;
                    data_element.Name = new_account.Name;
                }
            }
            db.SaveChanges();
            data.Clear();
        }

        private static void ChangeBudget(int id, BudgetData new_budget)
        {
            var db = new DbManager();
            var data = db.Budgets.ToList();

            foreach (var data_element in data)
            {
                if (data_element.ID == id)
                {
                    data_element.CurrentSum = new_budget.CurrentSum;
                    data_element.MaxSum = new_budget.MaxSum;
                    data_element.Name = new_budget.Name;
                    data_element.Time = new_budget.Time;
                }
            }
            db.SaveChanges();
            data.Clear();
        }

        private static void ChangeCalendar(int id, CalendarData new_calendar)
        {
            var db = new DbManager();
            var data = db.Calendars.ToList();

            foreach (var data_element in data)
            {
                if (data_element.ID == id)
                {
                    data_element.Tasks = new_calendar.Tasks;
                    data_element.Time = new_calendar.Time;
                }
            }
            db.SaveChanges();
            data.Clear();
        }

        private static void ChangeIncome(int id, IncomeData new_income)
        {
            var db = new DbManager();
            var data = db.Income.ToList();

            foreach (var data_element in data)
            {
                if (data_element.ID == id)
                {
                    data_element.Account = new_income.Account;
                    data_element.Category = new_income.Category;
                    data_element.CurrentSum = new_income.CurrentSum;
                    data_element.Time = new_income.Time;
                }
            }
            db.SaveChanges();
            data.Clear();
        }

        private static void ChangeSpending(int id, SpendingData new_spending)
        {
            var db = new DbManager();
            var data = db.Spendings.ToList();

            foreach (var data_element in data)
            {
                if (data_element.ID == id)
                {
                    data_element.Account = new_spending.Account;
                    data_element.Category = new_spending.Category;
                    data_element.CurrentSum = new_spending.CurrentSum;
                    data_element.Time = new_spending.Time;
                }
            }
            db.SaveChanges();
            data.Clear();
        }

        private static void ChangePreferences(int id, PreferenceData new_preference)
        {
            var db = new DbManager();
            var data = db.Preferences.ToList();

            foreach (var data_element in data)
            {
                if (data_element.ID == id)
                {
                    data_element.CurrentSum = new_preference.CurrentSum;
                    data_element.MaxSum = new_preference.MaxSum;
                    data_element.Name = new_preference.Name;
                    data_element.Time = new_preference.Time;
                }
            }
            db.SaveChanges();
            data.Clear();
        }

        private static void ChangeReports(int id, ReportData new_report)
        {
            var db = new DbManager();
            var data = db.Reports.ToList();

            foreach (var data_element in data)
            {
                if (data_element.ID == id)
                {
                    data_element.Account = new_report.Account;
                    data_element.Budget = new_report.Budget;
                    data_element.Income = new_report.Income;
                    data_element.IsIncome = new_report.IsIncome;
                    data_element.Spending = new_report.Spending;
                    data_element.Time = new_report.Time;
                    data_element.Preference = new_report.Preference;
                }
            }
            db.SaveChanges();
            data.Clear();
        }
    }
}
