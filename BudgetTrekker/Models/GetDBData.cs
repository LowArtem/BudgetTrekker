using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrekker.Models
{
    class GetDBData : IDisposable
    {
        private List<AccountData> accountDatas;
        private List<BudgetData> budgetDatas;
        private List<CalendarData> calendarDatas;
        private List<IncomeData> incomeDatas;
        private List<PreferenceData> preferenceDatas;
        private List<ReportData> reportDatas;
        private List<SpendingData> spendingDatas;

        public GetDBData()
        {
            var db = new DbManager();

            this.accountDatas = db.Accounts.ToList();
            this.budgetDatas = db.Budgets.ToList();
            this.calendarDatas = db.Calendars.ToList();
            this.incomeDatas = db.Income.ToList();
            this.preferenceDatas = db.Preferences.ToList();
            this.reportDatas = db.Reports.ToList();
            this.spendingDatas = db.Spendings.ToList();
        }

        public void Dispose()
        {
            this.accountDatas = null;
            this.budgetDatas = null;
            this.calendarDatas = null;
            this.incomeDatas = null;
            this.preferenceDatas = null;
            this.reportDatas = null;
            this.spendingDatas = null;
        }

        public List<AccountData> GetAccounts()
        {
            return this.accountDatas;
        }

        public List<BudgetData> GetBudget()
        {
            return this.budgetDatas;
        }

        public List<CalendarData> GetCalendars()
        {
            return this.calendarDatas;
        }

        public List<IncomeData> GetIncomes()
        {
            return this.incomeDatas;
        }

        public List<PreferenceData> GetPreferences()
        {
            return this.preferenceDatas;
        }

        public List<ReportData> GetReports()
        {
            return this.reportDatas;
        }

        public List<SpendingData> GetSpendings()
        {
            return this.spendingDatas;
        }
    }
}
