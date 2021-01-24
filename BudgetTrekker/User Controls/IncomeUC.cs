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
    public partial class IncomeUC : UserControl
    {
        private List<IncomeData> incomeDatas;

        public IncomeUC()
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
            infoPanel.BackColor = Color.FromArgb(223, 247, 223);
            GlobalFunctions.SetColorChildPanels(Color.FromArgb(200, 234, 201), ref infoPanel);

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
            #endregion
        }

        private void AddCategorySum(ref List<double> sums, ref List<string> categories, IncomeData income)
        {
            for (int i = 0; i < categories.Count; i++)
            {
                if (income.Category == categories[i])
                {
                    sums[i] += income.CurrentSum;
                    break;
                }
            }
        }

        private List<double> SumController(ref List<IncomeData> list)
        {
            List<string> categoriesList = IncomeCategories.GetCategoriesList();
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

        private void Controller(ref List<double> list, ref Label label1, ref Label label2, ref Label label3, ref Label label4, ref Label label5)
        {
            List<Label> labels = new List<Label>();
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);

            TableController(ref list, ref labels);
            labels.Clear();
        }

        public void DBInit()
        {
            using (DbManager db = new DbManager())
            {
                this.incomeDatas = db.Income.ToList();
            }

            var yesterdayIncomeList = this.incomeDatas.Where(t => t.Time.Date == DateTime.Now.AddDays(-1).Date).ToList();
            var todayIncomeList = this.incomeDatas.Where(t => t.Time.Date == DateTime.Now.Date).ToList();
            var weekIncomeList = this.incomeDatas.Where(t => t.Time.Date >= DateTime.Now.Date.StartOfWeek(DayOfWeek.Monday).Date).ToList();
            var monthIncomeList = this.incomeDatas.Where(t => t.Time.Date >= DateTime.Now.Date.StartOfMonth().Date).ToList();
            var yearIncomeList = this.incomeDatas.Where(t => t.Time.Date >= DateTime.Now.Date.StartOfYear().Date).ToList();

            var yesterdaySumList = SumController(ref yesterdayIncomeList);
            var todaySumList = SumController(ref todayIncomeList);
            var weekSumList = SumController(ref weekIncomeList);
            var monthSumList = SumController(ref monthIncomeList);
            var yearSumList = SumController(ref yearIncomeList);

            Controller(ref todaySumList, ref this.amount1, ref this.amount6, ref this.amount11, ref this.amount16, ref this.amount21);
            Controller(ref yesterdaySumList, ref this.amount2, ref this.amount7, ref this.amount12, ref this.amount17, ref this.amount22);
            Controller(ref weekSumList, ref this.amount3, ref this.amount8, ref this.amount13, ref this.amount18, ref this.amount23);
            Controller(ref monthSumList, ref this.amount4, ref this.amount9, ref this.amount14, ref this.amount19, ref this.amount24);
            Controller(ref yearSumList, ref this.amount5, ref this.amount10, ref this.amount15, ref this.amount20, ref this.amount25);
        }
    }
}
