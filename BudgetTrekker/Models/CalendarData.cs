using System;
using System.Collections.Generic;

namespace BudgetTrekker.Models
{
    public class CalendarData
    {
        public int ID { get; set; } = 1;
        public DateTime Time { get; set; }
        public virtual ICollection<Models.TaskData> Tasks { get; set; }


        public CalendarData(DateTime time)
        {
            this.Time = time;
            this.Tasks = new List<Models.TaskData>();
        }

        public CalendarData(DateTime time, ICollection<Models.TaskData> tasks)
        {
            this.Time = time;
            this.Tasks = tasks;
        }

        public CalendarData() { }
    }
}
