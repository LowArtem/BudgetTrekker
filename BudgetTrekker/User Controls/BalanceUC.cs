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
    public partial class BalanceUC : UserControl
    {
        public static string Today_income { get; private set; } = "0";
        public static string Today_spending { get; private set; } = "0";
        public static string Today_total_str { get; private set; } = "0";
        public static string Yesterday_income { get; private set; } = "0";
        public static string Yesterday_spending { get; private set; } = "0";
        public static string Yesterday_total_str { get; private set; } = "0";

        private List<IncomeData> incomeDatas;
        private List<SpendingData> spendingDatas;

        public BalanceUC()
        {
            InitializeComponent();

            ColorController();

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


        /////////////////////////////////////////
        // another Methods
        /////////////////////////////////////////


        private void ColorController()
        {
            todayPanel.BackColor = Color.FromArgb(230, 230, 230);
            yestardayPanel.BackColor = Color.FromArgb(215, 215, 215);
            weekPanel.BackColor = Color.FromArgb(215, 215, 215);

            panel1.BackColor = Color.FromArgb(200, 200, 200);
            panel2.BackColor = Color.FromArgb(200, 200, 200);
            panel3.BackColor = Color.FromArgb(200, 200, 200);
            panel4.BackColor = Color.FromArgb(200, 200, 200);
            panel5.BackColor = Color.FromArgb(200, 200, 200);
            panel6.BackColor = Color.FromArgb(200, 200, 200);
            panel8.BackColor = Color.FromArgb(200, 200, 200);
            panel9.BackColor = Color.FromArgb(200, 200, 200);
            panel12.BackColor = Color.FromArgb(200, 200, 200);
            panel13.BackColor = Color.FromArgb(200, 200, 200);
            panel14.BackColor = Color.FromArgb(200, 200, 200);

            label4.BackColor = Color.FromArgb(200, 234, 201);
            label5.BackColor = Color.FromArgb(247, 179, 178);
            label6.BackColor = Color.White;

            label9.BackColor = Color.FromArgb(200, 234, 201);
            label8.BackColor = Color.FromArgb(247, 179, 178);
            label7.BackColor = Color.White;

            label18.BackColor = Color.FromArgb(200, 234, 201);
            label16.BackColor = Color.FromArgb(247, 179, 178);
            label12.BackColor = Color.White;

            WplusLB.BackColor = Color.FromArgb(200, 234, 201);
            WminusLB.BackColor = Color.FromArgb(247, 179, 178);
            WtotalLB.BackColor = Color.White;

            TDplusLB.BackColor = Color.FromArgb(200, 234, 201);
            TDminusLB.BackColor = Color.FromArgb(247, 179, 178);
            TDtotalLB.BackColor = Color.White;

            YDplusLB.BackColor = Color.FromArgb(200, 234, 201);
            YDminusLB.BackColor = Color.FromArgb(247, 179, 178);
            YDtotalLB.BackColor = Color.White;
        }

        private double DaySum(ref List<IncomeData> incomes)
        {
            double sum = 0;
            foreach (var i in incomes)
            {
                sum += i.CurrentSum;
            }
            return sum;
        }

        private double DaySum(ref List<SpendingData> spendings)
        {
            double sum = 0;
            foreach (var i in spendings)
            {
                sum += i.CurrentSum;
            }
            return sum;
        }

        private double TotalSum(ref List<IncomeData> incomes, ref List<SpendingData> spendings)
        {
            double sum = 0;
            foreach (var i in incomes)
            {
                sum += i.CurrentSum;
            }

            foreach (var i in spendings)
            {
                sum -= i.CurrentSum;
            }
            return sum;
        }

        public void DBInit()
        {
            using (DbManager db = new DbManager())
            {
                this.incomeDatas = db.Income.ToList();
                this.spendingDatas = db.Spendings.ToList();
            }

            double TodayIncomeSum = 0;
            double YesterdayIncomeSum = 0;

            double TodaySpendingSum = 0;
            double YesterdaySpendingSum = 0;

            double WeekIncomeSum = 0;
            double WeekSpendingSum = 0;

            double TodayTotal = 0;
            double YesterdayTotal = 0;

            double WeekTotal = 0;
            double MonthTotal = 0;
            double YearTotal = 0;

            var yesterdayIncomeList = this.incomeDatas.Where(t => t.Time.Date == DateTime.Now.AddDays(-1).Date).ToList();
            var todayIncomeList = this.incomeDatas.Where(t => t.Time.Date == DateTime.Now.Date).ToList();
            var weekIncomeList = this.incomeDatas.Where(t => t.Time.Date >= DateTime.Now.Date.StartOfWeek(DayOfWeek.Monday).Date).ToList();
            var monthIncomeList = this.incomeDatas.Where(t => t.Time.Date >= DateTime.Now.Date.StartOfMonth().Date).ToList();
            var yearIncomeList = this.incomeDatas.Where(t => t.Time.Date >= DateTime.Now.Date.StartOfYear().Date).ToList();

            var yesterdaySpendingList = this.spendingDatas.Where(t => t.Time.Date == DateTime.Now.AddDays(-1).Date).ToList();
            var todaySpendingList = this.spendingDatas.Where(t => t.Time.Date == DateTime.Now.Date).ToList();
            var weekSpendingList = this.spendingDatas.Where(t => t.Time.Date >= DateTime.Now.Date.StartOfWeek(DayOfWeek.Monday).Date).ToList();
            var monthSpendingList = this.spendingDatas.Where(t => t.Time.Date >= DateTime.Now.Date.StartOfMonth().Date).ToList();
            var yearSpendingList = this.spendingDatas.Where(t => t.Time.Date >= DateTime.Now.Date.StartOfYear().Date).ToList();


            TodayIncomeSum = DaySum(ref todayIncomeList);
            YesterdayIncomeSum = DaySum(ref yesterdayIncomeList);
            WeekIncomeSum = DaySum(ref weekIncomeList);

            TodaySpendingSum = DaySum(ref todaySpendingList);
            YesterdaySpendingSum = DaySum(ref yesterdaySpendingList);            
            WeekSpendingSum = DaySum(ref weekSpendingList);

            TodayTotal = TodayIncomeSum - TodaySpendingSum;
            YesterdayTotal = YesterdayIncomeSum - YesterdaySpendingSum;

            WeekTotal = TotalSum(ref weekIncomeList, ref weekSpendingList);
            MonthTotal = TotalSum(ref monthIncomeList, ref monthSpendingList);
            YearTotal = TotalSum(ref yearIncomeList, ref yearSpendingList);

            TDplusLB.Text = TodayIncomeSum.ToString("n", new System.Globalization.CultureInfo("ru-RU"));
            TDminusLB.Text = TodaySpendingSum.ToString("n", new System.Globalization.CultureInfo("ru-RU"));

            if (TodayTotal <= 0)
                TDtotalLB.Text = TodayTotal.ToString("n", new System.Globalization.CultureInfo("ru-RU"));
            else
                TDtotalLB.Text = "+" + TodayTotal.ToString("n", new System.Globalization.CultureInfo("ru-RU"));

            YDplusLB.Text = YesterdayIncomeSum.ToString("n", new System.Globalization.CultureInfo("ru-RU"));
            YDminusLB.Text = YesterdaySpendingSum.ToString("n", new System.Globalization.CultureInfo("ru-RU"));

            if (YesterdayTotal <= 0)
                YDtotalLB.Text = YesterdayTotal.ToString("n", new System.Globalization.CultureInfo("ru-RU"));
            else
                YDtotalLB.Text = "+" + YesterdayTotal.ToString("n", new System.Globalization.CultureInfo("ru-RU"));

            WplusLB.Text = WeekIncomeSum.ToString("n", new System.Globalization.CultureInfo("ru-RU"));
            WminusLB.Text = WeekSpendingSum.ToString("n", new System.Globalization.CultureInfo("ru-RU"));

            if (WeekTotal <= 0)
                WtotalLB.Text = WeekTotal.ToString("n", new System.Globalization.CultureInfo("ru-RU"));
            else
                WtotalLB.Text = "+" + WeekTotal.ToString("n", new System.Globalization.CultureInfo("ru-RU"));

            if (MonthTotal <= 0)
                monthTotalLB.Text = MonthTotal.ToString("n", new System.Globalization.CultureInfo("ru-RU"));
            else
                monthTotalLB.Text = "+" + MonthTotal.ToString("n", new System.Globalization.CultureInfo("ru-RU"));

            if (YearTotal <= 0)
                yearTotalLB.Text = YearTotal.ToString("n", new System.Globalization.CultureInfo("ru-RU"));
            else
                yearTotalLB.Text = "+" + YearTotal.ToString("n", new System.Globalization.CultureInfo("ru-RU"));

            Today_income = TodayIncomeSum.ToString("n", new System.Globalization.CultureInfo("ru-RU"));
            Today_spending = TodaySpendingSum.ToString("n", new System.Globalization.CultureInfo("ru-RU"));

            Yesterday_income = YesterdayIncomeSum.ToString("n", new System.Globalization.CultureInfo("ru-RU"));
            Yesterday_spending = YesterdaySpendingSum.ToString("n", new System.Globalization.CultureInfo("ru-RU"));

            if (TodayTotal <= 0)
                Today_total_str = TodayTotal.ToString("n", new System.Globalization.CultureInfo("ru-RU"));
            else
                Today_total_str = "+" + TodayTotal.ToString("n", new System.Globalization.CultureInfo("ru-RU"));

            if (YesterdayTotal <= 0)
                Yesterday_total_str = YesterdayTotal.ToString("n", new System.Globalization.CultureInfo("ru-RU"));
            else
                Yesterday_total_str = "+" + YesterdayTotal.ToString("n", new System.Globalization.CultureInfo("ru-RU"));
        }
    }
}
