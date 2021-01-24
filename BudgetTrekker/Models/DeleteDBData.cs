using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetTrekker.Models
{
    static class DeleteDBData
    {
        public static void DeleteAccount(int id)
        {
            var db = new DbManager();
            var data = db.Accounts.ToList();

            foreach (var data_element in data)
            {
                var getData = new GetDBData();
                var reportData = getData.GetReports();
                var incomeData = getData.GetIncomes();
                var spendingData = getData.GetSpendings();
                getData.Dispose();

                if (data_element.ID == id)
                {
                    foreach (var report in reportData)
                    {
                        if (report.Account.ID == id)
                        {
                            db.Reports.Remove(report);
                        }
                    }

                    foreach (var income in incomeData)
                    {
                        if (income.Account.ID == id)
                        {
                            db.Income.Remove(income);
                        }
                    }

                    foreach (var spending in spendingData)
                    {
                        if (spending.Account.ID == id)
                        {
                            db.Spendings.Remove(spending);
                        }
                    }

                    db.Accounts.Remove(data_element);
                    break;
                }
            }

            db.SaveChanges();
            data.Clear();
        }

        public static void DeleteBudget(int id)
        {
            var db = new DbManager();
            var data = db.Budgets.ToList();

            foreach (var data_element in data)
            {
                if (data_element.ID == id)
                {
                    db.Budgets.Remove(data_element);
                }
            }
            db.SaveChanges();
            data.Clear();
        }

        /// <summary>
        /// Delete tasks in calendar for calendar date. If calendar is clear, delete calendar
        /// </summary>
        /// <param name="currentDate">calendar date to delete tasks</param>
        public static void DeleteCalendarTasks(DateTime currentDate)
        {
            var db = new DbManager();
            var data = db.Calendars.ToList();

            foreach (var data_element in data)
            {
                List<TaskData> tasks;
                if (data_element.Time.ToShortDateString() == currentDate.ToShortDateString())
                {
                    tasks = data_element.Tasks.ToList();
                    foreach (var task_item in tasks)
                    {
                        if (task_item.IsComplete)
                        {
                            data_element.Tasks.Remove(task_item);
                            db.Tasks.Remove(task_item);
                            break; // не уверен в надобности
                        }
                    }

                    if (data_element.Tasks.Count == 0)
                    {
                        db.Calendars.Remove(data_element);
                        break;
                    }
                }
            }
            
            db.SaveChanges();
            data.Clear();
        }

        public static void DeleteIncome(int id)
        {
            var db = new DbManager();
            var data = db.Income.ToList();

            foreach (var data_element in data)
            {
                if (data_element.ID == id)
                {
                    db.Income.Remove(data_element);
                }
            }
            db.SaveChanges();
            data.Clear();
        }

        public static void DeleteSpending(int id)
        {
            var db = new DbManager();
            var data = db.Spendings.ToList();

            foreach (var data_element in data)
            {
                if (data_element.ID == id)
                {
                    db.Spendings.Remove(data_element);
                }
            }
            db.SaveChanges();
            data.Clear();
        }

        public static void DeletePreferences(int id)
        {
            var db = new DbManager();
            var data = db.Preferences.ToList();

            foreach (var data_element in data)
            {
                if (data_element.ID == id)
                {
                    db.Preferences.Remove(data_element);
                }
            }
            db.SaveChanges();
            data.Clear();
        }

        public static void DeleteReports(int id)
        {
            var db = new DbManager();
            var data = db.Reports.ToList();

            foreach (var data_element in data)
            {
                if (data_element.ID == id)
                {
                    db.Reports.Remove(data_element);
                }
            }
            db.SaveChanges();
            data.Clear();
        }
    }
}
