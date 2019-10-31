using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTrekker.User_Controls
{
    public partial class BalanceUC : UserControl
    {
        public BalanceUC()
        {
            InitializeComponent();

            ColorController();
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

            panel1.BackColor = Color.FromArgb(200, 200, 200);
            panel2.BackColor = Color.FromArgb(200, 200, 200);
            panel3.BackColor = Color.FromArgb(200, 200, 200);
            panel4.BackColor = Color.FromArgb(200, 200, 200);
            panel5.BackColor = Color.FromArgb(200, 200, 200);
            panel6.BackColor = Color.FromArgb(200, 200, 200);
            panel7.BackColor = Color.FromArgb(200, 200, 200);
            panel8.BackColor = Color.FromArgb(200, 200, 200);
            panel9.BackColor = Color.FromArgb(200, 200, 200);

            label4.BackColor = Color.FromArgb(200, 234, 201);
            label5.BackColor = Color.FromArgb(247, 179, 178);
            label6.BackColor = Color.White;

            label9.BackColor = Color.FromArgb(200, 234, 201);
            label8.BackColor = Color.FromArgb(247, 179, 178);
            label7.BackColor = Color.White;

            TDplusLB.BackColor = Color.FromArgb(200, 234, 201);
            TDminusLB.BackColor = Color.FromArgb(247, 179, 178);
            TDtotalLB.BackColor = Color.White;

            YDplusLB.BackColor = Color.FromArgb(200, 234, 201);
            YDminusLB.BackColor = Color.FromArgb(247, 179, 178);
            YDtotalLB.BackColor = Color.White;
        }
    }
}
