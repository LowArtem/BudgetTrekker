using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrekker.Models
{
    // TODO: подумать, какие именно настройки и как добаить в БД, да и нужны ли они вообще
    class Settings
    {
        public int ID { get; set; }
        public BudgetData Budgets { get; set; }
        public PreferenceData Preferences { get; set; }
        public AccountData Accounts { get; set; }
        public IncomeData Income { get; set; }
        public SpendingData Spendings { get; set; }
    }
}
