using System;
using System.Collections.Generic;

namespace BudgetTrekker.Models
{
    public class CalendarData
    {
        public int ID { get; set; } = 1;
        public DateTime Time { get; set; }
        public virtual List<Models.TaskData> Tasks { get; set; }


        public CalendarData(DateTime time, List<Models.TaskData> tasks)
        {
            this.Time = time;
            this.Tasks = tasks;
        }

        public CalendarData() { }
    }
}
