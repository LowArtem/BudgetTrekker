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
using System.Text.RegularExpressions;

namespace BudgetTrekker.User_Controls
{
    public  partial class AccountsUS : UserControl
    {
        public static List<string> accountsName = new List<string>();
        public static List<string> accountsSum = new List<string>();
        public static List<string> accountsTime = new List<string>();

        private List<ReportData> reportDatas;
        private List<AccountData> accountDatas;
        private List<IncomeData> incomeDatas;
        private List<SpendingData> spendingDatas;

        public AccountsUS()
        {
            InitializeComponent();

            GlobalFunctions.SetColorChildPanels(Color.FromArgb(255, 224, 204), ref mainPanel);
                       
            tableLayoutPanel1.AutoScroll = true;

            DBInit();

            TableElementsInit();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }        

        private void addBtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            int index = 0;
            using (DbManager db = new DbManager())
            {
                var test = db.Accounts.OrderByDescending(i => i.Index).ToList();
                if (test.Count > 0)
                    index = test[0].Index;
                test.Clear();
            }

            AccountData account = new AccountData("Название", index + 1, "0", 0);
            using (DbManager db = new DbManager())
            {
                db.Accounts.Add(account);
                db.SaveChanges();
            }

            TableElementsAdd(account);
        }



        /////////////////////////////////////////
        // another Methods
        /////////////////////////////////////////


        
        private void TableElementsInit()
        {
            for (int i = 0; i < accountDatas.Count; i++)
            {
                TableElementsAdd(accountDatas[i]);
            }

            if (accountDatas.Count == 0)
            {
                tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            }
            else
            {
                tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None; 
            }

        }

        private void TableElementsAdd(AccountData account)
        {
            AccountPanel accountPanel = new AccountPanel(account);

            tableLayoutPanel1.Controls.Add(accountPanel, account.Index - 1, 0);
        }      

        public void DBInit()
        {
            accountsName.Clear();
            accountsSum.Clear();
            accountsTime.Clear();

            using (DbManager db = new DbManager())
            {
                this.accountDatas = db.Accounts.ToList();
                this.reportDatas = db.Reports.OrderByDescending(t => t.Time).ToList();
                this.incomeDatas = db.Income.ToList();
                this.spendingDatas = db.Spendings.ToList();
            }

            var accountPanels = GlobalFunctions.GetAllChildControls(tableLayoutPanel1, typeof(AccountPanel));
            foreach (var panel in accountPanels)
            {
                ((AccountPanel)panel).DBInit();

                accountsName.Add(((AccountPanel)panel).accountName);
                accountsSum.Add(((AccountPanel)panel).accountSum);
                accountsTime.Add(((AccountPanel)panel).accountTime);
            }            
        }
    }
}
