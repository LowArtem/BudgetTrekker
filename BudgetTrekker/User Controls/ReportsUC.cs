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
    // TODO: сделать сортировку истории по счетам, доходам/расходам и т д
    //       сделать автоматическое обновление истории при изменении имени аккаунта
    public partial class ReportsUC : UserControl
    {
        private List<BudgetData> budgetDatas;
        private List<PreferenceData> preferenceDatas;

        public ReportsUC()
        {
            InitializeComponent();

            infoPanel.BackColor = Color.FromArgb(203, 207, 209, 204);
            listBox1.BackColor = Color.FromArgb(203, 207, 209);

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

        public void DBInit()
        {
            listBox1.Items.Clear();
            using (DbManager db = new DbManager())
            {
                this.budgetDatas = db.Budgets.ToList();
                this.preferenceDatas = db.Preferences.ToList();

                var data = db.Reports.ToList();
                foreach (var data_element in data)
                {
                    listBox1.Items.Add(data_element.ReportCombine());
                }
            }
        }
    }
}
