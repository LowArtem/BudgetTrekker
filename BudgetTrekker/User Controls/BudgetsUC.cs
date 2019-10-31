using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetTrekker.Models;
using System.IO;

namespace BudgetTrekker.User_Controls
{
    public partial class BudgetsUC : UserControl
    {
        public BudgetsUC()
        {
            InitializeComponent();

            infoPanel.BackColor = Color.FromArgb(255, 255, 195);
            GlobalFunctions.SetColorChildPanels(Color.FromArgb(246, 246, 136), ref infoPanel);
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        // Temporal test method
        private void Button2_Click(object sender, EventArgs e)
        {            
            using (DbManager db = new DbManager())
            {
                BudgetData budget = new BudgetData("Budget name 2", 5700, 500, DateTime.Now);
                PreferenceData preference = new PreferenceData("Preference name 2", 1500, 200, DateTime.Now);
                AccountData account = new AccountData("Account name 2", 2, 0, 8000);
                IncomeData income = new IncomeData(IncomeCategories.Mother, 15000, account, DateTime.Now);
                SpendingData spending = new SpendingData(SpendingsCategories.Food, 1000, account, DateTime.Now);
                ReportData report = new ReportData(DateTime.Now, income, spending, false);
                Models.TaskData task = new Models.TaskData("Найти смысл жизни");
                CalendarData calendar = new CalendarData(DateTime.Now, task.ToList());

                Data data = new Data(budget, preference, account, income, spending, report, calendar);

                db.Data.Add(data);
                db.SaveChanges();


                string test = "";

                var datas = db.Calendars.ToList();
                foreach (var data_element in datas)
                {                    
                    if (data_element.Tasks != null)
                    {
                        foreach (var task2 in data_element.Tasks)
                        {
                             test += task2.TaskText + "\n";                       
                        }
                        
                    }
                    else
                        MessageBox.Show("Calendar is null");
                }
                MessageBox.Show(test);
            }
              
        }
    }
}
