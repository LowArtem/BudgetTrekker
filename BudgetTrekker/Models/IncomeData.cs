using System;

namespace BudgetTrekker.Models
{
    public class IncomeData
    {
        public string Category
        {
            get
            {
                return this.Category_hide;
            }
            set
            {
                if (IncomeCategories.isRightCategory(value))
                { 
                    this.Category_hide = value;
                }
                else
                {
                    this.Category_hide = null;
                }
            }
        }
        
        private string Category_hide { get; set; }
        public int ID { get; set; } = 1;
        public double CurrentSum { get; set; } = 0;
        public virtual AccountData Account { get; set; }
        public DateTime Time { get; set; }



        public IncomeData(string category, double current_sum, AccountData account, DateTime time)
        {
            this.Category_hide = category;
            this.CurrentSum = current_sum;
            this.Account = account;
            this.Time = time;
        }

        public IncomeData() { }
    }
}