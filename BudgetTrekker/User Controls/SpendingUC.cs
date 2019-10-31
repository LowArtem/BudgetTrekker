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
    public partial class SpendingUC : UserControl
    {
        public SpendingUC()
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
    }
}
