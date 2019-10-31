using System;

namespace BudgetTrekker.Models
{
    public class PreferenceData
    {
        public int ID { get; set; } = 1;
        public string Name { get; set; } = "Название";
        public int MaxSum { get; set; } = 0;
        public int CurrentSum { get; set; } = 0;
        public DateTime Time { get; set; }



        public PreferenceData(string name, int max_sum, int current_sum, DateTime time)
        {
            this.Name = name;
            this.MaxSum = max_sum;
            this.CurrentSum = current_sum;
            this.Time = time;
        }

        public PreferenceData() { }
    }
}