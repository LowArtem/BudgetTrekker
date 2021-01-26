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

namespace BudgetTrekker.User_Controls
{
    public partial class AccountPanel : UserControl
    {        
        public virtual AccountData Account { get; set; }

        public string accountTime = "0";
        public string accountName = "0";
        public string accountSum = "0";

        private List<AccountData> accountDatas;
        private List<ReportData> reportDatas;
        private List<IncomeData> incomeDatas;
        private List<SpendingData> spendingDatas;

        private TextBox accountNameTB;
        private TextBox accountSumTB;
        private TextBox cardNumberTB;
        private Label cardNumberLbl;

        public AccountPanel(AccountData account)
        {
            InitializeComponent();
            this.Account = account;

            errorTransactionLbl.Visible = false;
            this.BackColor = Color.FromArgb(255, 224, 204);
            lastTransactionsPanel.BackColor = Color.FromArgb(252, 231, 217);

            this.lastTransactionsPanel.AutoScroll = true;

            settingsBtn.BackColor = Color.FromArgb(218, 189, 171);
            settingsBtn.Text = "⋮";
            deleteBtnToolTip.SetToolTip(deleteBtn, "Удалить счет безвозвратно?");
            deleteBtn.Visible = false;

            DBInit();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            // Открытие настроек
            if (settingsBtn.Text == "⋮")
            {
                SettingsOpen(sender, e);
            }
            // Закрытие настроек
            else
            {
                SettingsClose(sender, e);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            using (DbManager db = new DbManager())
            {
                var accountData = db.Accounts.ToList();
                var reportData = db.Reports.ToList();
                var incomeData = db.Income.ToList();
                var spendingData = db.Spendings.ToList();

                foreach (var data_element in accountData)
                {
                    if (data_element.ID == this.Account.ID)
                    {
                        foreach (var report in reportData)
                        {
                            if (report.Account.ID == this.Account.ID)
                            {
                                db.Reports.Remove(report);
                            }
                        }

                        foreach (var income in incomeData)
                        {
                            if (income.Account.ID == this.Account.ID)
                            {
                                db.Income.Remove(income);
                            }
                        }

                        foreach (var spending in spendingData)
                        {
                            if (spending.Account.ID == this.Account.ID)
                            {
                                db.Spendings.Remove(spending);
                            }
                        }                        

                        db.Accounts.Remove(data_element);
                        this.Dispose();
                        break;
                    }
                }

                db.SaveChanges();
            }
        }


        private void Init()
        {
            errorTransactionLbl.Visible = false;

            accountNameLbl.Text = this.Account.Index.ToString() + ". " + this.Account.Name;
            accountSumLbl.Text = this.Account.CashSum.ToString("n", new System.Globalization.CultureInfo("ru-RU")) + " руб";

            var reportsForAccountList = this.reportDatas.Where(p => p.Account.ID == this.Account.ID).ToList();

            try
            {
                this.accountTime = reportsForAccountList[0].Time.ToShortDateString();
                this.accountSum = accountSumLbl.Text;
                this.accountName = accountNameLbl.Text;
            }
            catch (ArgumentOutOfRangeException)
            {

            }

            if (reportsForAccountList != null && reportsForAccountList.Count > 0)
            {
                lastTransactionsPanel.RowStyles.Clear();

                for (int i = 0; i < reportsForAccountList.Count; i++)
                {
                    MiniTransactionPanelController(ref lastTransactionsPanel, reportsForAccountList[i]);
                }

                reportsForAccountList.Clear();
            }
            else
            {
                errorTransactionLbl.Visible = true;
            }
        }

        private void MiniTransactionPanelController(ref TableLayoutPanel lastTransactionsPanel, ReportData reportData)
        {
            LastTransactionPanel lastTransactionPanel;
            if (reportData.IsIncome)
            {
                lastTransactionPanel = new LastTransactionPanel(reportData.Time.ToString(), reportData.Income.CurrentSum.ToString(), 
                                                                reportData.Income.Category, true);
            }
            else
            {
                lastTransactionPanel = new LastTransactionPanel(reportData.Time.ToString(), reportData.Spending.CurrentSum.ToString(),
                                                                reportData.Spending.Category, false);
            }

            lastTransactionPanel.BorderStyle = BorderStyle.FixedSingle;
            lastTransactionPanel.BackColor = lastTransactionsPanel.BackColor;
            lastTransactionPanel.Size = new Size(250, 100);

            lastTransactionsPanel.Controls.Add(lastTransactionPanel);
        }

        // Открытие настроек
        private void SettingsOpen(object sender, EventArgs e)
        {
            settingsBtn.Text = "x";
            lastTransactionsPanel.Visible = false;
            lastTransactionNameLbl.Visible = false;
            accountNameLbl.Visible = false;
            accountSumLbl.Visible = false;

            deleteBtn.Visible = true;

            accountNameTB = new TextBox();
            accountNameTB.Text = this.Account.Name;
            accountNameTB.Parent = this;
            accountNameTB.Location = accountNameLbl.Location;
            accountNameTB.Size = accountNameLbl.Size;
            accountNameTB.Font = accountNameLbl.Font;
            accountNameTB.Visible = true;

            accountSumTB = new TextBox();
            accountSumTB.Text = this.Account.CashSum.ToString();
            accountSumTB.Parent = this;
            accountSumTB.Location = accountSumLbl.Location;
            accountSumTB.Size = accountSumLbl.Size;
            accountSumTB.Font = accountSumLbl.Font;
            accountSumTB.KeyPress += SumTB_KeyPress;
            accountSumTB.Visible = true;

            cardNumberLbl = new Label();
            cardNumberLbl.Text = "Номер счета/карты:";
            cardNumberLbl.AutoSize = true;
            cardNumberLbl.Parent = this;
            cardNumberLbl.Location = new Point(5, 140);
            cardNumberLbl.Font = accountSumLbl.Font;
            cardNumberLbl.ForeColor = Color.Black;

            cardNumberTB = new TextBox();
            cardNumberTB.Text = this.Account.CardNumber.ToString();
            cardNumberTB.Parent = this;
            cardNumberTB.Location = new Point(5, 140 + cardNumberLbl.Height);
            cardNumberTB.AutoSize = true;
            cardNumberTB.Font = accountSumTB.Font;
            cardNumberTB.KeyPress += SumTB_KeyPress;
            cardNumberTB.Visible = true;
        }
        
        // Закрытие настроек
        private void SettingsClose(object sender, EventArgs e)
        {
            settingsBtn.Text = "⋮";
            lastTransactionsPanel.Visible = true;
            lastTransactionNameLbl.Visible = true;
            accountNameLbl.Visible = true;
            accountSumLbl.Visible = true;

            accountNameTB.Visible = false;
            deleteBtn.Visible = false;
            accountSumTB.Visible = false;
            cardNumberTB.Visible = false;
            cardNumberLbl.Visible = false;

            // Изменение Названия Счета
            if (!string.IsNullOrEmpty(accountNameTB.Text) && accountNameLbl.Text != (this.Account.Index + ". " + accountNameTB.Text))
            {
                using (DbManager db = new DbManager())
                {
                    var accountData = db.Accounts.ToList();

                    foreach (var data_element in accountData)
                    {
                        if (data_element.ID == this.Account.ID)
                        {
                            data_element.Name = accountNameTB.Text;
                            this.Account.Name = accountNameTB.Text;
                            accountNameLbl.Text = this.Account.Index + ". " + accountNameTB.Text;
                            break;
                        }
                    }

                    db.SaveChanges();
                }
            }

            // Изменение Суммы Счета
            if (!string.IsNullOrEmpty(accountSumTB.Text) && accountSumLbl.Text != (accountSumTB.Text + " руб"))
            {
                using (DbManager db = new DbManager())
                {
                    var accountData = db.Accounts.ToList();

                    foreach (var data_element in accountData)
                    {
                        if (data_element.ID == this.Account.ID)
                        {
                            data_element.CashSum = Convert.ToDouble(accountSumTB.Text);
                            this.Account.CashSum = Convert.ToDouble(accountSumTB.Text);
                            accountSumLbl.Text = this.Account.CashSum.ToString("n", new System.Globalization.CultureInfo("ru-RU")) + " руб";
                            break;
                        }
                    }

                    db.SaveChanges();
                }
            }

            // Изменение номера карты/счета
            if (!string.IsNullOrEmpty(cardNumberTB.Text) && cardNumberTB.Text != this.Account.CardNumber.ToString())
            {
                using (DbManager db = new DbManager())
                {
                    var accountData = db.Accounts.ToList();

                    foreach (var data_element in accountData)
                    {
                        if (data_element.ID == this.Account.ID)
                        {
                            data_element.CardNumber = cardNumberTB.Text;
                            this.Account.CardNumber = cardNumberTB.Text;                            
                            break;
                        }
                    }

                    db.SaveChanges();
                }
            }


            accountNameTB.Dispose();
            accountSumTB.Dispose();
            cardNumberTB.Dispose();
            cardNumberLbl.Dispose();
        }

        private void SumTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)Keys.Back & e.KeyChar != (Char)Keys.Delete & e.KeyChar != ',')
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
        }

        public void DBInit()
        {
            using (DbManager db = new DbManager())
            {
                this.accountDatas = db.Accounts.ToList();
                this.reportDatas = db.Reports.OrderByDescending(t => t.Time).ToList();
                this.incomeDatas = db.Income.ToList();
                this.spendingDatas = db.Spendings.ToList();
            }

            foreach (var data_element in accountDatas)
            {
                if (data_element.ID == this.Account.ID)
                {
                    this.Account = data_element;
                    break;
                }
            }

            Init();
        }
    }
}
