using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            GlobalFunctions.SetColorChildPanels(Color.FromArgb(200, 234, 201), ref incomePanel);
            GlobalFunctions.SetColorChildPanels(Color.FromArgb(247, 179, 178), ref spendingPanel);
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
