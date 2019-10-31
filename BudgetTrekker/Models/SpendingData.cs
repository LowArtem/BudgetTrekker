using System;

namespace BudgetTrekker.Models
{
    public class SpendingData
    {
        public string Category
        {
            get
            {
                return this.Category_hide;
            }
            set
            {
                if (value == SpendingsCategories.Credit || value == SpendingsCategories.PublicService || value == SpendingsCategories.Food ||
                    value == SpendingsCategories.Personal || value == SpendingsCategories.Entertainment ||
                    value == SpendingsCategories.Transport || value == SpendingsCategories.Other)
                {
                    this.Category_hide = value;
                }
                else
                {
                    this.Category_hide = null;
                }
            }
        }
        private string Category_hide;
        public int ID { get; set; } = 1;
        public int CurrentSum { get; set; } = 0;
        public virtual AccountData Account { get; set; }
        public DateTime Time { get; set; }



        public SpendingData(string category, int current_sum, AccountData account, DateTime time)
        {
            this.Category = category;
            this.CurrentSum = current_sum;
            this.Account = account;
            this.Time = time;
        }

        public SpendingData() { }
    }
}