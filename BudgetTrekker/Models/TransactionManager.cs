using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrekker.Models
{
    // Отвечает за обработку всех денежных поступлений в программу
    class TransactionManager
    {
        public bool IsIncome { get; private set; } = true; // получение денег или траты
        public double ReceivedAmount { get; private set; } = 0; // полученная сумма
        public double SpentAmount { get; private set; } = 0; // потраченная сумма
        public DateTime Time { get; private set; } = DateTime.Now; // время поступления / траты
        public AccountData Account { get; private set; } // счет поступления / траты
        public BudgetData Budget { get; private set; } // категория бюджета, в который зачислить сумму
        public PreferenceData Preference { get; private set; } // категория предпочтений, в которую зачислить сумму
        public string IncomeCategory { get; private set; } = ""; // категория поступления (из списка IncomeCategories)
        public string SpendingCategory { get; private set; } = ""; // категория траты (из списка SpendingCategories)


        public Exception Exeption { get; private set; } = null; // информация об ошибке, если она есть


        /// <summary>
        /// Processes all financial transactions in the program
        /// </summary>
        /// <param name="isIncome">If money is received - true, if spent - false</param>
        /// <param name="amount">Amount of money</param>
        /// <param name="time">DateTime when money is received or spent</param>
        /// <param name="account">AccountData object: To which account to send money</param>
        /// <param name="category">Income or Spend category: from the relevant classes (Model/?Categories)</param>
        /// <param name="budget">BudgetData obj: To which budget to send money (optional)</param>
        /// <param name="preference">PreferenceData obj: To which preference to send money (optional)</param>
        public TransactionManager(bool isIncome, double amount, DateTime time, AccountData account, string category, BudgetData budget)
        {
            this.IsIncome = isIncome;
            this.Time = time;
            this.Account = account;
            this.Budget = budget;

            this.Preference = null;

            if (isIncome) // поступление
            {
                this.ReceivedAmount = amount;
                this.IncomeCategory = category;

                this.SpentAmount = 0;
                this.SpendingCategory = "";
            }
            else // трата
            {
                this.SpentAmount = amount;
                this.SpendingCategory = category;

                this.ReceivedAmount = 0;
                this.IncomeCategory = "";
            }
        }

        public TransactionManager(bool isIncome, double amount, DateTime time, AccountData account, string category, PreferenceData preference)
        {
            this.IsIncome = isIncome;
            this.Time = time;
            this.Account = account;
            this.Preference = preference;

            this.Budget = null;

            if (isIncome) // поступление
            {
                this.ReceivedAmount = amount;
                this.IncomeCategory = category;

                this.SpentAmount = 0;
                this.SpendingCategory = "";
            }
            else // трата
            {
                this.SpentAmount = amount;
                this.SpendingCategory = category;

                this.ReceivedAmount = 0;
                this.IncomeCategory = "";
            }
        }

        public TransactionManager(bool isIncome, double amount, DateTime time, AccountData account, string category)
        {
            this.IsIncome = isIncome;
            this.Time = time;
            this.Account = account;

            this.Budget = null;
            this.Preference = null;

            if (isIncome) // поступление
            {
                this.ReceivedAmount = amount;
                this.IncomeCategory = category;

                this.SpentAmount = 0;
                this.SpendingCategory = "";
            }
            else // трата
            {
                this.SpentAmount = amount;
                this.SpendingCategory = category;

                this.ReceivedAmount = 0;
                this.IncomeCategory = "";
            }
        }

        /// <summary>
        /// Sends this transit to the program.
        /// </summary>
        /// <returns>True if transit is successful, false if transit is failed.</returns>
        public bool SendMoney()
        {
            using (DbManager db = new DbManager())
            {
                try
                {
                    var accountDataList = db.Accounts.ToList();
                    foreach (var data_element in accountDataList)
                    {
                        if (data_element.ID == this.Account.ID)
                        {
                            if (this.IsIncome)
                                data_element.CashSum += this.ReceivedAmount;
                            else
                                data_element.CashSum -= this.SpentAmount;
                            this.Account = data_element;
                            break;
                        }
                    }

                    if (this.Budget != null)
                    {
                        int id = this.Budget.ID;
                        var budgetDataList = db.Budgets.ToList();
                        foreach (var data_element in budgetDataList)
                        {
                            if (data_element.ID == id)
                            {
                                if (this.IsIncome)
                                    data_element.CurrentSum -= this.ReceivedAmount;
                                else
                                    data_element.CurrentSum += this.SpentAmount;
                                this.Budget = data_element;
                                break;
                            }
                        }
                    }
                    if (this.Preference != null)
                    {
                        int id = this.Preference.ID;
                        var preferenceDataList = db.Preferences.ToList();
                        foreach (var data_element in preferenceDataList)
                        {
                            if (data_element.ID == id)
                            {
                                if (this.IsIncome)
                                    data_element.CurrentSum -= this.ReceivedAmount;
                                else
                                    data_element.CurrentSum += this.SpentAmount;
                                this.Preference = data_element;
                                break;
                            }
                        }
                    }



                    if (this.IsIncome) // поступление
                    {
                        var incomeData = new IncomeData(this.IncomeCategory, this.ReceivedAmount, this.Account, this.Time);
                        //db.Income.Add(incomeData);

                        ReportData reportData;

                        if (this.Budget != null)
                            reportData = new ReportData(this.Time, incomeData, this.Budget);
                        else if (this.Preference != null)
                            reportData = new ReportData(this.Time, incomeData, this.Preference);
                        else
                            reportData = new ReportData(this.Time, incomeData);

                        db.Reports.Add(reportData);
                    }
                    else // трата
                    {
                        var spendingData = new SpendingData(this.SpendingCategory, this.SpentAmount, this.Account, this.Time);
                        //db.Spendings.Add(spendingData);

                        ReportData reportData;

                        if (this.Budget != null)
                            reportData = new ReportData(this.Time, spendingData, this.Budget);
                        else if (this.Preference != null)
                            reportData = new ReportData(this.Time, spendingData, this.Preference);
                        else
                            reportData = new ReportData(this.Time, spendingData);

                        db.Reports.Add(reportData);                       
                    }
                }
                catch (Exception e)
                {
                    this.Exeption = e;
                    return false;
                }

                db.SaveChanges();
                return true;
            }
        }
    }
}
