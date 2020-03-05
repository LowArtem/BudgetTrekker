using System;

namespace BudgetTrekker.Models
{
    public class PreferenceData
    {
        public int ID { get; set; } = 1;
        public string Name { get; set; } = "Название";
        public double MaxSum { get; set; } = 0;
        public double CurrentSum { get; set; } = 0;
        public DateTime Time { get; set; }



        public PreferenceData(string name, double max_sum, double current_sum, DateTime time)
        {
            this.Name = name;
            this.MaxSum = max_sum;
            this.CurrentSum = current_sum;
            this.Time = time;
        }

        public PreferenceData() { }

        /// <summary>
        /// Returns the percentage of the current amount to the maximum amount.
        /// </summary>
        /// <returns></returns>
        public int GetPercentCurrentToMax()
        {
            if (MaxSum != 0)
            {
                double number = Convert.ToDouble(this.CurrentSum) / Convert.ToDouble(this.MaxSum);
                int answer_value = Convert.ToInt32(Math.Round(number, 2, MidpointRounding.AwayFromZero) * 100);
                return answer_value;
            }
            else
                return 0;
        }
    }
}