using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetTrekker.User_Controls;

namespace BudgetTrekker
{
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();

            balancePanel.BackColor = Color.FromArgb(230,230,230);
            accountsPanel.BackColor = Color.FromArgb(255,224,204);
            budgetsPanel.BackColor = Color.FromArgb(255,255,195);
            incomePanel.BackColor = Color.FromArgb(223,247,223);
            spendingPanel.BackColor = Color.FromArgb(255,204,203);


            GlobalFunctions.SetColorChildPanels(Color.FromArgb(207, 207, 207), ref balancePanel);
            GlobalFunctions.SetColorChildPanels(Color.FromArgb(255, 208, 178), ref accountsPanel);
            GlobalFunctions.SetColorChildPanels(Color.FromArgb(246, 246, 136), ref budgetsPanel);

            #region Income panels color
            this.incPanel1.BackColor = Color.FromArgb(200, 234, 201);
            this.incPanel2.BackColor = Color.FromArgb(200, 234, 201);
            this.incPanel3.BackColor = Color.FromArgb(200, 234, 201);
            this.incPanel4.BackColor = Color.FromArgb(200, 234, 201);
            this.incPanel5.BackColor = Color.FromArgb(200, 234, 201);
            #endregion

            #region Spending panels color
            this.spePanel1.BackColor = Color.FromArgb(247, 179, 178);
            this.spePanel2.BackColor = Color.FromArgb(247, 179, 178);
            this.spePanel3.BackColor = Color.FromArgb(247, 179, 178);
            this.spePanel4.BackColor = Color.FromArgb(247, 179, 178);
            this.spePanel5.BackColor = Color.FromArgb(247, 179, 178);
            #endregion

            DBInit();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void BalanceData()
        {
            label12.Text = BalanceUC.Today_income;
            label13.Text = BalanceUC.Today_spending;
            label16.Text = BalanceUC.Today_total_str;
            label15.Text = BalanceUC.Yesterday_income;
            label14.Text = BalanceUC.Yesterday_spending;
            label18.Text = BalanceUC.Yesterday_total_str;
        }

        private void AccountsData()
        {
            if (AccountsUS.accountsName.Count > 1)
            {
                try
                {
                    label20.Text = AccountsUS.accountsName[1];
                    label23.Text = AccountsUS.accountsTime[1];
                    label22.Text = AccountsUS.accountsSum[1];
                }
                catch (ArgumentOutOfRangeException)
                {
                    label20.Text = "Счета не обнаружены";
                }

                try
                {
                    label27.Text = AccountsUS.accountsName[0];
                    label24.Text = AccountsUS.accountsTime[0];
                    label25.Text = AccountsUS.accountsSum[0];
                }
                catch (ArgumentOutOfRangeException)
                {
                    label27.Text = "Счета не обнаружены";
                }
            }
            else
            {
                try
                {
                    label20.Text = AccountsUS.accountsName[0];
                    label23.Text = AccountsUS.accountsTime[0];
                    label22.Text = AccountsUS.accountsSum[0];
                }
                catch (ArgumentOutOfRangeException)
                {
                    label20.Text = "Счета не обнаружены";
                }

                label27.Text = "Счета не обнаружены";
            }
        }

        private void BudgetsData()
        {
            label29.Text = BudgetsUC.budgetsName[0];
            label30.Text = BudgetsUC.budgetsCurrentSum[0];
            label31.Text = BudgetsUC.budgetsSum[0];
            label28.Text = BudgetsUC.budgetsProcent[0].ToString() + "%";
            try
            {
                progressBar1.Value = BudgetsUC.budgetsProcent[0];
            }
            catch(ArgumentOutOfRangeException)
            {
                progressBar1.Value = progressBar1.Maximum;
            }

            label34.Text = BudgetsUC.budgetsName[1];
            label33.Text = BudgetsUC.budgetsCurrentSum[1];
            label32.Text = BudgetsUC.budgetsSum[1];
            label35.Text = BudgetsUC.budgetsProcent[1].ToString() + "%";
            try
            {
                progressBar2.Value = BudgetsUC.budgetsProcent[1];
            }
            catch (ArgumentOutOfRangeException)
            {
                progressBar2.Value = progressBar2.Maximum;
            }

            label38.Text = BudgetsUC.budgetsName[2];
            label37.Text = BudgetsUC.budgetsCurrentSum[2];
            label36.Text = BudgetsUC.budgetsSum[2];
            label39.Text = BudgetsUC.budgetsProcent[2].ToString() + "%";
            try
            {
                progressBar3.Value = BudgetsUC.budgetsProcent[2];
            }
            catch (ArgumentOutOfRangeException)
            {
                progressBar3.Value = progressBar3.Maximum;
            }
        }

        public void DBInit()
        {
            // Прием данных из BalanceUC
            BalanceData();


            // Прием данных из AccountsUC
            AccountsData();


            // Прием данных из BudgetsUC
            BudgetsData();
        }

        public void IncomeData(IncomeUC incomeUC)
        {
            // Берет данные из IncomeUC и заполняет этими данными таблицу в HomeUC
            // вызывается при инициализации этой формы (HomeUC)

            inc1.Text = incomeUC.amount1.Text;
            inc2.Text = incomeUC.amount3.Text;
            inc3.Text = incomeUC.amount4.Text;
            inc4.Text = incomeUC.amount5.Text;
            inc5.Text = incomeUC.amount6.Text;
            inc6.Text = incomeUC.amount8.Text;
            inc7.Text = incomeUC.amount9.Text;
            inc8.Text = incomeUC.amount10.Text;
            inc9.Text = incomeUC.amount11.Text;
            inc10.Text = incomeUC.amount13.Text;

            inc11.Text = incomeUC.amount14.Text;
            inc12.Text = incomeUC.amount15.Text;
            inc13.Text = incomeUC.amount16.Text;
            inc14.Text = incomeUC.amount18.Text;
            inc15.Text = incomeUC.amount19.Text;
            inc16.Text = incomeUC.amount20.Text;
            inc17.Text = incomeUC.amount21.Text;
            inc18.Text = incomeUC.amount23.Text;
            inc19.Text = incomeUC.amount24.Text;
            inc20.Text = incomeUC.amount25.Text;
        }

        public void SpendingData(SpendingUC spendingUC)
        {
            // Берет данные из SpendingUC и заполняет этими данными таблицу в HomeUC
            // вызывается при инициализации этой формы (HomeUC)

            sp1.Text = spendingUC.amount6.Text;
            sp2.Text = spendingUC.amount8.Text;
            sp3.Text = spendingUC.amount9.Text;
            sp4.Text = spendingUC.amount10.Text;
            sp5.Text = spendingUC.amount11.Text;
            sp6.Text = spendingUC.amount13.Text;
            sp7.Text = spendingUC.amount14.Text;
            sp8.Text = spendingUC.amount15.Text;
            sp9.Text = spendingUC.amount16.Text;
            sp10.Text = spendingUC.amount18.Text;

            sp11.Text = spendingUC.amount19.Text;
            sp12.Text = spendingUC.amount20.Text;
            sp13.Text = spendingUC.amount26.Text;
            sp14.Text = spendingUC.amount28.Text;
            sp15.Text = spendingUC.amount29.Text;
            sp16.Text = spendingUC.amount30.Text;
            sp17.Text = spendingUC.amount31.Text;
            sp18.Text = spendingUC.amount33.Text;
            sp19.Text = spendingUC.amount34.Text;
            sp20.Text = spendingUC.amount35.Text;
        }
    }
}
