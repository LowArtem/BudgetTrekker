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
    public partial class ReportsUC : UserControl
    {
        public ReportsUC()
        {
            InitializeComponent();

            infoPanel.BackColor = Color.FromArgb(203, 207, 209, 204);
            listBox1.BackColor = Color.FromArgb(203, 207, 209);

            using (DbManager db = new DbManager())
            {
                var data = db.Reports.ToList();
                foreach (var data_element in data)
                {
                    listBox1.Items.Add(data_element.ReportCombiner());
                }
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }
    }
}
