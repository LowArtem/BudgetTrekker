using System;
using System.Collections.Generic;

namespace BudgetTrekker.Models
{
    public class TaskData
    {
        public int ID { get; set; } = 1;
        public string TaskText { get; set; }
        public bool IsComplete { get; set; } = false;



        public TaskData(string text, bool isComplete = false)
        {
            this.TaskText = text;
            this.IsComplete = isComplete;
        }
        public TaskData() { }


        internal List<TaskData> ToList()
        {
            var list = new List<TaskData>();
            list.Add(this);
            return list;
        }
    }
}
