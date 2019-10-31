using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BudgetTrekker.Models
{
    class DbManager : DbContext
    {
        public DbManager() : base("DbConnection") { }

        //public DbSet<Settings> Settings { get; set; }
        public DbSet<Data> Data { get; set; }
        public DbSet<BudgetData> Budgets { get; set; }
        public DbSet<PreferenceData> Preferences { get; set; }
        public DbSet<AccountData> Accounts { get; set; }
        public DbSet<IncomeData> Income { get; set; }
        public DbSet<SpendingData> Spendings { get; set; }
        public DbSet<ReportData> Reports { get; set; }
        public DbSet<CalendarData> Calendars { get; set; }
    }
}
