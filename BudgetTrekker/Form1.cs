using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetTrekker.User_Controls;

namespace BudgetTrekker
{
    public partial class Form1 : Form
    {
        public static bool IsAccountChanged = false;


        HomeUC HomeUC;
        BalanceUC BalanceUC;
        IncomeUC IncomeUC;
        SpendingUC SpendingUC;
        AccountsUS AccountsUS;
        BudgetsUC BudgetsUC;
        ReportsUC ReportsUC;
        CalendarUC CalendarUC;
        PreferencesUC PreferencesUC;
        SettingsUC SettingsUC;


        public Form1()
        {
            InitializeComponent();

            HomeUC = new HomeUC();
            HomeUC.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(HomeUC);

            ChangeButtonColor(ref homeBtn);
            this.HomeUC.BringToFront();
            dragControl1.SelectControl = HomeUC.mainPanel;


            BalanceUC = new BalanceUC();
            BalanceUC.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(BalanceUC);


            IncomeUC = new IncomeUC();
            IncomeUC.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(IncomeUC);


            SpendingUC = new SpendingUC();
            SpendingUC.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(SpendingUC);


            AccountsUS = new AccountsUS();
            AccountsUS.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(AccountsUS);


            BudgetsUC = new BudgetsUC();
            BudgetsUC.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(BudgetsUC);


            ReportsUC = new ReportsUC();
            ReportsUC.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(ReportsUC);


            CalendarUC = new CalendarUC();
            CalendarUC.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(CalendarUC);


            PreferencesUC = new PreferencesUC();
            PreferencesUC.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(PreferencesUC);


            SettingsUC = new SettingsUC();
            SettingsUC.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(SettingsUC);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.HomeUC.BringToFront();
            dragControl1.SelectControl = HomeUC.mainPanel;

            ChangeButtonColor(ref homeBtn);
        }

        private void Balance_btn_Click(object sender, EventArgs e)
        {
            this.BalanceUC.BringToFront();
            dragControl1.SelectControl = BalanceUC.mainPanel;

            ChangeButtonColor(ref balance_btn);
        }

        private void Income_btn_Click(object sender, EventArgs e)
        {
            this.IncomeUC.BringToFront();
            dragControl1.SelectControl = IncomeUC.mainPanel;

            ChangeButtonColor(ref income_btn);
        }

        private void Spending_btn_Click(object sender, EventArgs e)
        {
            this.SpendingUC.BringToFront();
            dragControl1.SelectControl = SpendingUC.mainPanel;

            ChangeButtonColor(ref spending_btn);
        }

        private void Accounts_btn_Click(object sender, EventArgs e)
        {
            if (IsAccountChanged)
            {
                this.AccountsUS.Dispose();
                AccountsUS = new AccountsUS();
                AccountsUS.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(AccountsUS);

                this.AccountsUS.BringToFront();
                dragControl1.SelectControl = AccountsUS.mainPanel;
                ChangeButtonColor(ref accounts_btn);

                IsAccountChanged = false;
            }
            else
            {
                this.AccountsUS.DBInit();
                this.AccountsUS.BringToFront();
                dragControl1.SelectControl = AccountsUS.mainPanel;

                ChangeButtonColor(ref accounts_btn);
            }
        }

        private void Budgets_btn_Click(object sender, EventArgs e)
        {
            this.BudgetsUC.DBInit();
            this.BudgetsUC.BringToFront();
            dragControl1.SelectControl = BudgetsUC.mainPanel;

            ChangeButtonColor(ref budgets_btn);
        }

        private void Reports_btn_Click(object sender, EventArgs e)
        {
            this.ReportsUC.DBInit();
            this.ReportsUC.BringToFront();            
            dragControl1.SelectControl = ReportsUC.mainPanel;

            ChangeButtonColor(ref reports_btn);
        }

        private void Calendar_btn_Click(object sender, EventArgs e)
        {
            this.CalendarUC.BringToFront();
            dragControl1.SelectControl = CalendarUC.mainPanel;

            ChangeButtonColor(ref calendar_btn);
        }

        private void Preferences_btn_Click(object sender, EventArgs e)
        {
            this.PreferencesUC.DBInit();
            this.PreferencesUC.BringToFront();
            dragControl1.SelectControl = PreferencesUC.mainPanel;

            ChangeButtonColor(ref preferences_btn);
        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {
            this.SettingsUC.DBInit();
            this.SettingsUC.BringToFront();
            dragControl1.SelectControl = SettingsUC.mainPanel;

            ChangeButtonColor(ref settings_btn);
        }
        


        /////////////////////////////////////////
        // another Methods
        /////////////////////////////////////////



        private void ChangeButtonColor(ref Button currentButton)
        {
            Button[] buttons = new[] {this.homeBtn, this.balance_btn, this.income_btn, this.spending_btn, this.accounts_btn,
                                      this.budgets_btn, this.reports_btn, this.calendar_btn, this.preferences_btn, this.settings_btn};


            for (int i = 0; i < buttons.Length; i++)
            {
                if (currentButton != buttons[i])
                {
                    buttons[i].BackColor = Color.Gray;
                }
            }

            currentButton.BackColor = Color.FromArgb(64, 64, 64);
        }
    }
}
