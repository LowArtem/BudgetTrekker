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
    public partial class SettingsUC : UserControl
    {
        private List<AccountData> accountDatas;
        private List<BudgetData> budgetDatas;
        private List<PreferenceData> preferenceDatas;

        public SettingsUC()
        {
            InitializeComponent();

            transactionTypeCB.SelectedIndex = 0;

            SetCategories();

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

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)Keys.Back & e.KeyChar != (Char)Keys.Delete & e.KeyChar != ',')
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
        }

        private void TransactionTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCategories();
        }

        private void BudgetCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            preferenceCB.SelectedIndex = -1;
        }

        private void PreferenceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            budgetCB.SelectedIndex = -1;
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            Form1.IsAccountChanged = true;

            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "0" && categoryCB.SelectedIndex != -1 && accountCB.SelectedIndex != -1)
            {
                bool isIncome = transactionTypeCB.SelectedIndex == 1;

                if (preferenceCB.SelectedIndex == -1 && budgetCB.SelectedIndex == -1)
                {
                    TransactionManager transactionManager = new TransactionManager(isIncome, Convert.ToDouble(textBox1.Text), DateTime.Now,
                        accountDatas[accountCB.SelectedIndex], categoryCB.SelectedItem.ToString());
                    bool isOK = transactionManager.SendMoney();

                    if (!isOK)
                        MessageBox.Show(transactionManager.Exeption.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (budgetCB.SelectedIndex != -1)
                {
                    TransactionManager transactionManager = new TransactionManager(isIncome, Convert.ToDouble(textBox1.Text), DateTime.Now,
                        accountDatas[accountCB.SelectedIndex], categoryCB.SelectedItem.ToString(), budgetDatas[budgetCB.SelectedIndex]);
                    bool isOK = transactionManager.SendMoney();

                    if (!isOK)
                        MessageBox.Show(transactionManager.Exeption.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (preferenceCB.SelectedIndex != -1)
                {
                    TransactionManager transactionManager = new TransactionManager(isIncome, Convert.ToDouble(textBox1.Text), DateTime.Now,
                        accountDatas[accountCB.SelectedIndex], categoryCB.SelectedItem.ToString(), preferenceDatas[preferenceCB.SelectedIndex]);
                    bool isOK = transactionManager.SendMoney();

                    if (!isOK)
                        MessageBox.Show(transactionManager.Exeption.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не все обязательные поля заполнены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Не все обязательные поля заполнены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        /////////////////////////////////////////
        // another Methods
        /////////////////////////////////////////




        private void SetCategories()
        {
            categoryCB.Items.Clear();

            if (transactionTypeCB.SelectedIndex == 0)
                categoryCB.Items.AddRange(SpendingsCategories.GetCategoriesList().ToArray());
            else
                categoryCB.Items.AddRange(IncomeCategories.GetCategoriesList().ToArray());
        }

        public void DBInit()
        {
            using (DbManager db = new DbManager())
            {
                this.accountDatas = db.Accounts.ToList();
                this.budgetDatas = db.Budgets.ToList();
                this.preferenceDatas = db.Preferences.ToList();
            }

            accountCB.Items.Clear();
            foreach (var account in accountDatas)
            {
                accountCB.Items.Add(account.Name);
            }

            budgetCB.Items.Clear();
            foreach (var budget in budgetDatas)
            {
                budgetCB.Items.Add(budget.Name);
            }

            preferenceCB.Items.Clear();
            foreach (var preference in preferenceDatas)
            {
                preferenceCB.Items.Add(preference.Name);
            }
        }
    }
}
