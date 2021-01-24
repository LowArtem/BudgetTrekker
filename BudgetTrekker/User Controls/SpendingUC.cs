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
    public partial class SpendingUC : UserControl
    {
        private List<SpendingData> spendingDatas;

        public SpendingUC()
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
            infoPanel.BackColor = Color.FromArgb(255, 204, 203);
            GlobalFunctions.SetColorChildPanels(Color.FromArgb(247, 179, 178), ref infoPanel);

            #region lines color
            line1.BackColor = Color.Black;
            line2.BackColor = Color.Black;
            line3.BackColor = Color.Black;
            line4.BackColor = Color.Black;
            line5.BackColor = Color.Black;
            line6.BackColor = Color.Black;
            line7.BackColor = Color.Black;
            line8.BackColor = Color.Black;
            line9.BackColor = Color.Black;
            line10.BackColor = Color.Black;
            line11.BackColor = Color.Black;
            line12.BackColor = Color.Black;
            line13.BackColor = Color.Black;
            line14.BackColor = Color.Black;
            line15.BackColor = Color.Black;
            line16.BackColor = Color.Black;
            line17.BackColor = Color.Black;
            line18.BackColor = Color.Black;
            line19.BackColor = Color.Black;
            line20.BackColor = Color.Black;
            line21.BackColor = Color.Black;
            line22.BackColor = Color.Black;
            line23.BackColor = Color.Black;
            line24.BackColor = Color.Black;
            line25.BackColor = Color.Black;
            line26.BackColor = Color.Black;
            line27.BackColor = Color.Black;
            line28.BackColor = Color.Black;
            line29.BackColor = Color.Black;
            line30.BackColor = Color.Black;
            line31.BackColor = Color.Black;
            line32.BackColor = Color.Black;
            line33.BackColor = Color.Black;
            line34.BackColor = Color.Black;
            line35.BackColor = Color.Black;
            #endregion

        }

        private void AddCategorySum(ref List<double> sums, ref List<string> categories, SpendingData Spending)
        {
            for (int i = 0; i < categories.Count; i++)
            {
                if (Spending.Category == categories[i])
                {
                    sums[i] += Spending.CurrentSum;
                    break;
                }
            }
        }

        private List<double> SumController(ref List<SpendingData> list)
        {
            List<string> categoriesList = SpendingsCategories.GetCategoriesList();
            List<double> sumList = new List<double>(categoriesList.Count);
            foreach (var i in categoriesList)
            {
                sumList.Add(0);
            }

            foreach (var i in list)
            {
                AddCategorySum(ref sumList, ref categoriesList, i);
            }

            return sumList;
        }

        private void TableController(ref List<double> sumList, ref List<Label> labels)
        {
            for (int i = 0; i < labels.Count; i++)
            {
                labels[i].Text = sumList[i].ToString("n", new System.Globalization.CultureInfo("ru-RU"));
            }
        }

        private void Controller(ref List<double> list, ref Label label1, ref Label label2, ref Label label3, ref Label label4, ref Label label5, ref Label label6, ref Label label7)
        {
            List<Label> labels = new List<Label>();
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);

            TableController(ref list, ref labels);
            labels.Clear();
        }

        public void DBInit()
        {
            using (DbManager db = new DbManager())
            {
                this.spendingDatas = db.Spendings.ToList();
            }

            var yesterdaySpendingList = this.spendingDatas.Where(t => t.Time.Date == DateTime.Now.AddDays(-1).Date).ToList();
            var todaySpendingList = this.spendingDatas.Where(t => t.Time.Date == DateTime.Now.Date).ToList();
            var weekSpendingList = this.spendingDatas.Where(t => t.Time.Date >= DateTime.Now.Date.StartOfWeek(DayOfWeek.Monday).Date).ToList();
            var monthSpendingList = this.spendingDatas.Where(t => t.Time.Date >= DateTime.Now.Date.StartOfMonth().Date).ToList();
            var yearSpendingList = this.spendingDatas.Where(t => t.Time.Date >= DateTime.Now.Date.StartOfYear().Date).ToList();

            var yesterdaySumList = SumController(ref yesterdaySpendingList);
            var todaySumList = SumController(ref todaySpendingList);
            var weekSumList = SumController(ref weekSpendingList);
            var monthSumList = SumController(ref monthSpendingList);
            var yearSumList = SumController(ref yearSpendingList);

            Controller(ref todaySumList, ref this.amount1, ref this.amount6, ref this.amount11, ref this.amount16, ref this.amount21, ref this.amount26, ref this.amount31);
            Controller(ref yesterdaySumList, ref this.amount2, ref this.amount7, ref this.amount12, ref this.amount17, ref this.amount22, ref this.amount27, ref this.amount32);
            Controller(ref weekSumList, ref this.amount3, ref this.amount8, ref this.amount13, ref this.amount18, ref this.amount23, ref this.amount28, ref this.amount33);
            Controller(ref monthSumList, ref this.amount4, ref this.amount9, ref this.amount14, ref this.amount19, ref this.amount24, ref this.amount29, ref this.amount34);
            Controller(ref yearSumList, ref this.amount5, ref this.amount10, ref this.amount15, ref this.amount20, ref this.amount25, ref this.amount30, ref this.amount35);
        }
    }
}
