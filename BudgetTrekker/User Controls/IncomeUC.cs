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
    public partial class IncomeUC : UserControl
    {
        public IncomeUC()
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
    }
}
