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

            this.mainPanel.Controls["HomeUC"].BringToFront();
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
            this.mainPanel.Controls["HomeUC"].BringToFront();
            dragControl1.SelectControl = HomeUC.mainPanel;
        }

        private void Balance_btn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls["BalanceUC"].BringToFront();
            dragControl1.SelectControl = BalanceUC.mainPanel;
        }

        private void Income_btn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls["IncomeUC"].BringToFront();
            dragControl1.SelectControl = IncomeUC.mainPanel;
        }

        private void Spending_btn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls["SpendingUC"].BringToFront();
            dragControl1.SelectControl = SpendingUC.mainPanel;
        }

        private void Accounts_btn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls["AccountsUS"].BringToFront();
            dragControl1.SelectControl = AccountsUS.mainPanel;
        }

        private void Budgets_btn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls["BudgetsUC"].BringToFront();
            dragControl1.SelectControl = BudgetsUC.mainPanel;
        }

        private void Reports_btn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls["ReportsUC"].BringToFront();
            dragControl1.SelectControl = ReportsUC.mainPanel;
        }

        private void Calendar_btn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls["CalendarUC"].BringToFront();
            dragControl1.SelectControl = CalendarUC.mainPanel;
        }

        private void Preferences_btn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls["PreferencesUC"].BringToFront();
            dragControl1.SelectControl = PreferencesUC.mainPanel;
        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls["SettingsUC"].BringToFront();
            dragControl1.SelectControl = SettingsUC.mainPanel;
        }
    }
}
